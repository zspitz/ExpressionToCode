﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xunit;
using static ExpressionToString.Tests.Globals;
using static ExpressionToString.Tests.Runners;
using static System.Linq.Expressions.Expression;

namespace ExpressionToString.Tests.Constructed {
    [Trait("Source", "Autogenerated")]
    public class Unsorted {
        readonly bool @bool;
        readonly CallSiteBinder callSiteBinder;
        readonly Expression expression;
        readonly Expression[] expressionArray;
        readonly ExpressionType expressionType;
        readonly GotoExpressionKind gotoExpressionKind;
        readonly Guid guid;
        readonly int @int;
        readonly LabelTarget labelTarget;
        readonly LambdaExpression lambdaExpression;
        readonly MethodInfo methodInfo;
        readonly ParameterExpression[] parameterExpressionArray;
        readonly string @string;
        readonly SymbolDocumentInfo symbolDocumentInfo;
        readonly Type type;
        readonly Type[] typeArray;

        #region BinaryExpression
        [Fact(Skip = "Autogenerated tests")]
        public void MakeBinary_Test() =>
            BuildAssert(
                MakeBinary(expressionType, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeBinary_1_Test() =>
            BuildAssert(
                MakeBinary(expressionType, expression, expression, @bool, methodInfo),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeBinary_2_Test() =>
            BuildAssert(
                MakeBinary(expressionType, expression, expression, @bool, methodInfo, lambdaExpression),
                "",
                ""
            );
        #endregion

        #region bool

        [Fact(Skip = "Autogenerated tests")]
        public void TryGetActionType_Test() => BuildAssert(
                TryGetActionType(typeArray, out Type type1),
                "",
                ""
            );//TODO inspect type1

        [Fact(Skip = "Autogenerated tests")]
        public void TryGetFuncType_Test() => BuildAssert(
                TryGetFuncType(typeArray, out Type type1),
                "",
                ""
            );//TODO inspect type1

        #endregion

        #region DebugInfoExpression

        [Fact(Skip = "Autogenerated tests")]
        public void ClearDebugInfo_Test() =>
            BuildAssert(
                ClearDebugInfo(symbolDocumentInfo),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void DebugInfo_Test() =>
            BuildAssert(
                DebugInfo(symbolDocumentInfo, @int, @int, @int, @int),
                "",
                ""
            );

        #endregion

        #region DynamicExpression

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expressionArray),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_1_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_2_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_3_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Dynamic_4_Test() =>
            BuildAssert(
                Dynamic(callSiteBinder, type, expression, expression, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expressionArray),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_1_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_2_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_3_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression, expression, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeDynamic_4_Test() =>
            BuildAssert(
                MakeDynamic(type, callSiteBinder, expression, expression, expression, expression),
                "",
                ""
            );

        #endregion

        #region GotoExpression

        [Fact(Skip = "Autogenerated tests")]
        public void Break_Test() =>
            BuildAssert(
                Break(labelTarget),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Break_1_Test() =>
            BuildAssert(
                Break(labelTarget, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Break_2_Test() =>
            BuildAssert(
                Break(labelTarget, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Break_3_Test() =>
            BuildAssert(
                Break(labelTarget, expression, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Continue_Test() =>
            BuildAssert(
                Continue(labelTarget),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Continue_1_Test() =>
            BuildAssert(
                Continue(labelTarget, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Goto_Test() =>
            BuildAssert(
                Goto(labelTarget),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Goto_1_Test() =>
            BuildAssert(
                Goto(labelTarget, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Goto_2_Test() =>
            BuildAssert(
                Goto(labelTarget, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Goto_3_Test() =>
            BuildAssert(
                Goto(labelTarget, expression, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeGoto_Test() =>
            BuildAssert(
                MakeGoto(gotoExpressionKind, labelTarget, expression, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Return_Test() =>
            BuildAssert(
                Return(labelTarget),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Return_1_Test() =>
            BuildAssert(
                Return(labelTarget, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Return_2_Test() =>
            BuildAssert(
                Return(labelTarget, expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Return_3_Test() =>
            BuildAssert(
                Return(labelTarget, expression, type),
                "",
                ""
            );

        #endregion

        #region LabelExpression

        [Fact(Skip = "Autogenerated tests")]
        public void Label_Test() =>
            BuildAssert(
                Label(labelTarget),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Label_1_Test() =>
            BuildAssert(
                Label(labelTarget, expression),
                "",
                ""
            );

        #endregion

        #region LabelTarget

        [Fact(Skip = "Autogenerated tests")]
        public void Label_2_Test() =>
            BuildAssert(
                Label(),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Label_3_Test() =>
            BuildAssert(
                Label(@string),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Label_4_Test() =>
            BuildAssert(
                Label(type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Label_5_Test() =>
            BuildAssert(
                Label(type, @string),
                "",
                ""
            );

        #endregion

        #region LoopExpression

        [Fact(Skip = "Autogenerated tests")]
        public void Loop_Test() =>
            BuildAssert(
                Loop(expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Loop_1_Test() =>
            BuildAssert(
                Loop(expression, labelTarget),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Loop_2_Test() =>
            BuildAssert(
                Loop(expression, labelTarget, labelTarget),
                "",
                ""
            );

        #endregion

        #region ParameterExpression

        [Fact(Skip = "Autogenerated tests")]
        public void Variable_Test() =>
            BuildAssert(
                Variable(type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Variable_1_Test() =>
            BuildAssert(
                Variable(type, @string),
                "",
                ""
            );

        #endregion

        #region RuntimeVariablesExpression

        [Fact(Skip = "Autogenerated tests")]
        public void RuntimeVariables_Test() =>
            BuildAssert(
                RuntimeVariables(parameterExpressionArray),
                "",
                ""
            );

        #endregion

        #region SymbolDocumentInfo

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_Test() =>
            BuildAssert(
                SymbolDocument(@string),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_1_Test() =>
            BuildAssert(
                SymbolDocument(@string, guid),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_2_Test() =>
            BuildAssert(
                SymbolDocument(@string, guid, guid),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void SymbolDocument_3_Test() =>
            BuildAssert(
                SymbolDocument(@string, guid, guid, guid),
                "",
                ""
            );

        #endregion

        #region Type

        [Fact(Skip = "Autogenerated tests")]
        public void GetActionType_Test() =>
            BuildAssert(
                GetActionType(typeArray),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void GetDelegateType_Test() =>
            BuildAssert(
                GetDelegateType(typeArray),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void GetFuncType_Test() =>
            BuildAssert(
                GetFuncType(typeArray),
                "",
                ""
            );

        #endregion

        #region UnaryExpression

        [Fact(Skip = "Autogenerated tests")]
        public void MakeUnary_Test() =>
            BuildAssert(
                MakeUnary(expressionType, expression, type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void MakeUnary_1_Test() =>
            BuildAssert(
                MakeUnary(expressionType, expression, type, methodInfo),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Quote_Test() =>
            BuildAssert(
                Quote(expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Rethrow_Test() =>
            BuildAssert(
                Rethrow(),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Rethrow_1_Test() =>
            BuildAssert(
                Rethrow(type),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void UnaryPlus_Test() =>
            BuildAssert(
                UnaryPlus(expression),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void UnaryPlus_1_Test() =>
            BuildAssert(
                UnaryPlus(expression, methodInfo),
                "",
                ""
            );

        [Fact(Skip = "Autogenerated tests")]
        public void Unbox_Test() =>
            BuildAssert(
                Unbox(expression, type),
                "",
                ""
            );

        #endregion

    }
}
