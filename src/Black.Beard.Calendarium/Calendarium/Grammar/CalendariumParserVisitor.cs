//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CalendariumParser.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Bb.Calendaruim.Parser {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CalendariumParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
public interface ICalendariumParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScript([NotNull] CalendariumParser.ScriptContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.expression_bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression_bool([NotNull] CalendariumParser.Expression_boolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] CalendariumParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperation([NotNull] CalendariumParser.OperationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRule([NotNull] CalendariumParser.RuleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.mask"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMask([NotNull] CalendariumParser.MaskContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.dayweek"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDayweek([NotNull] CalendariumParser.DayweekContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CalendariumParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] CalendariumParser.IdentifierContext context);
}
} // namespace Bb.Calendaruim.Parser
