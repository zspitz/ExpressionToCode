﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAutoGrid;

namespace ExpressionTreeVisualizer {
    /// <summary>
    /// Interaction logic for VisualizerDataControl.xaml
    /// </summary>
    public partial class VisualizerDataControl : AutoGrid {
        public VisualizerDataControl() {
            InitializeComponent();

            Loaded += (s, e) => {
                tree.SelectedItemChanged += (s1, e1) => {
                    if (tree.SelectedItem==null) {
                        source.Select(0, 0);
                    } else {
                        (int start, int length) = ((KeyValuePair<string, ExpressionNodeData>)tree.SelectedItem).Value.Span;
                        source.Select(start, length);
                    }
                };

                // if we don't do this, the selection will only be visible if the textbox currently has the focus
                source.Focus();
                source.SelectAll();
            };
        }
    }
}
