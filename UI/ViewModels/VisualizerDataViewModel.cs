﻿using ExpressionTreeVisualizer.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using static ExpressionTreeVisualizer.Serialization.EndNodeTypes;
using ZSpitz.Util;
using ZSpitz.Util.Wpf;
using System.Windows.Input;

namespace ExpressionTreeVisualizer {
    public class VisualizerDataViewModel : ViewModelBase<VisualizerData> {
        public ExpressionNodeDataViewModel Root { get; }

        public List<ExpressionNodeDataViewModel> AllNodes { get; }

        public List<EndNodeGroupViewModel> Constants { get; }
        public List<EndNodeGroupViewModel> Parameters { get; }
        public List<EndNodeGroupViewModel> ClosedVars { get; }
        public List<EndNodeGroupViewModel> Defaults { get; }

        private readonly List<EndNodeGroupViewModel> allGroups;

        public VisualizerDataViewModel(VisualizerData model, ICommand? openInNewWindow=null, RelayCommand? copyWatchExpression = null) : base(model) {
            AllNodes = new List<ExpressionNodeDataViewModel>();
            Root = new ExpressionNodeDataViewModel(model.Root, AllNodes, openInNewWindow, copyWatchExpression);

            var grouped =
                AllNodes
                    .Where(x => x.Model.EndNodeType != null)
                    .GroupBy(
                        x => x.Model.EndNodeType!.Value,
                        (endNodeType, grp) => (
                            endNodeType,
                            grp.GroupBy(
                                x => x.Model.EndNodeData,
                                (endNodeData, grp1) => new EndNodeGroupViewModel(endNodeData, grp1)
                            )
                        )
                    )
                    .SelectMany(x => x.Item2.Select(y => (x.endNodeType, y)))
                    .ToLookup(x => x.endNodeType, x => x.y);

            Constants = grouped[Constant].ToList();
            Parameters = grouped[Parameter].ToList();
            ClosedVars = grouped[ClosedVar].ToList();
            Defaults = grouped[Default].ToList();

            allGroups = grouped.SelectMany().ToList();

            UpdateSelection = new RelayCommand(sender => {
                if (inUpdateSelection) { return; }

                inUpdateSelection = true;

                switch (sender) {
                    case string s:
                        var selected = FindNodeBySpan(SourceSelectionStart, SourceSelectionLength);
                        Root.ClearSelection(selected);
                        break;
                    case ExpressionNodeDataViewModel node:
                        Root.ClearSelection(node);
                        (SourceSelectionStart, SourceSelectionLength) = node.Model.Span;
                        break;
                    case EndNodeGroupViewModel group:
                        allGroups.Where(x => x != group).ForEach(x => x.IsSelected = false);
                        Root.ClearSelection(group.Nodes.ToArray());
                        (SourceSelectionStart, SourceSelectionLength) = group.Nodes.First().Model.Span;
                        break;
                    case null:
                        // previously selected group was unselected (presumably the only way for null to be passed in)
                        Root.ClearSelection();
                        break;
                    default:
                        throw new InvalidOperationException("Selection update from unknown part of viewmodel");
                }
                inUpdateSelection = false;
            });
        }

        private bool inUpdateSelection;

        public ExpressionNodeDataViewModel FindNodeBySpan(int start, int length) {
            var end = start + length;
            //if (start < NodeData.Span.start || end > NodeData.SpanEnd) { throw new ArgumentOutOfRangeException(); }
            var current = Root;
            while (true) {
                var child = 
                    (start, length) == (0,0) ?
                        current.Children.FirstOrDefault(x => x.Model.Span == (0,0)) :
                        current.Children.SingleOrDefault(x => x.Model.Span.start <= start && x.Model.SpanEnd >= end);
                if (child == null) { break; }
                current = child;
            }
            return current;
        }

        private int sourceSelectionStart;
        public int SourceSelectionStart {
            get => sourceSelectionStart;
            set => NotifyChanged(ref sourceSelectionStart, value);
        }

        private int sourceSelectionLength;

        public int SourceSelectionLength {
            get => sourceSelectionLength;
            set => NotifyChanged(ref sourceSelectionLength, value);
        }

        private int sourceSelectionEnd =>
            sourceSelectionLength == 0 ?
                sourceSelectionStart :
                sourceSelectionStart + sourceSelectionLength - 1;

        public RelayCommand UpdateSelection { get; }

        public string WindowTitle {
            get {
                var (formatter, language, path) = Model.Config;
                var parts = new List<(string? name, string? value)> {
                    {"Formatter", formatter }
                };
                if (formatter != language) {
                    parts.Add("Language", language);
                }
                if (!path.IsNullOrWhitespace()) {
                    parts.Add("Path", path);
                }
                return "Expression Tree Visualizer — " + parts.SelectT((name, val) => $"{name}: {val}").Joined(", ");
            }
        }
    }
}
