using Antlr4.Runtime.Misc;
using Bb.Calendaruim.Parser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace Bb.Calendarium
{
    internal class ParserBaseVisitor : CalendariumParserBaseVisitor<Expression>
    {

        static ParserBaseVisitor()
        {

            ParserBaseVisitor._methodAddDays = typeof(FunctionHelpers).GetMethod("AddDays", BindingFlags.Static | BindingFlags.Public);
            ParserBaseVisitor._methodBackDays = typeof(FunctionHelpers).GetMethod("Backs", BindingFlags.Static | BindingFlags.Public);
            ParserBaseVisitor._methodNextDays = typeof(FunctionHelpers).GetMethod("Nexts", BindingFlags.Static | BindingFlags.Public);

            ParserBaseVisitor._methodAddDay = typeof(FunctionHelpers).GetMethod("AddDay", BindingFlags.Static | BindingFlags.Public);
            ParserBaseVisitor._methodBackDay = typeof(FunctionHelpers).GetMethod("Back", BindingFlags.Static | BindingFlags.Public);
            ParserBaseVisitor._methodNextDay = typeof(FunctionHelpers).GetMethod("Next", BindingFlags.Static | BindingFlags.Public);

            ParserBaseVisitor._methodDayOfWeek = typeof(FunctionHelpers).GetMethod("DayOfWeek", BindingFlags.Static | BindingFlags.Public);

        }

        public ParserBaseVisitor(Calendar calendar)
        {
            Calendar = calendar;
            _stack = new Stack<Expression>();
            _year = Expression.Parameter(typeof(int), "_year_");
            _date = Expression.Parameter(typeof(DateTime), "_date_");
        }

        /// <summary>
        ///   expression
        /// | INTEROGATION expression_bool COLON expression
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Expression VisitScript([NotNull] CalendariumParser.ScriptContext context)
        {
            Expression result;

            if (context.INTEROGATION() != null)
            {
                _stack.Push(_date);
                var call = (MethodCallExpression)base.VisitScript(context);
                var e = VisitExpression_bool(context.expression_bool());
                var condition = Expression.Condition(e, call, _date);
                result = Expression.Lambda<Func<DateTime, DateTime>>(condition, _date);
            }
            else
            {
                var call = (MethodCallExpression)base.VisitScript(context);
                result = Expression.Lambda<Func<int, DateTime[]>>(call, _year);
            }

            return result;

        }

        /// <summary>
        ///    dayweek (OR dayweek)?
        /// |  LEFT_PAREN expression_bool RIGHT_PAREN
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Expression VisitExpression_bool([NotNull] CalendariumParser.Expression_boolContext context)
        {
            Expression result = null;
            var dayweeks = context.dayweek();
            if (dayweeks != null && dayweeks.Length > 0)
            {

                List<DayOfWeek> _days = new List<DayOfWeek>();

                foreach (var dayweek in dayweeks)
                {
                    var day = (ConstantExpression)VisitDayweek(dayweek);
                    _days.Add((DayOfWeek)day.Value);
                }
                Func<DateTime, DayOfWeek[], bool> method = FunctionHelpers.EvaluateDayweek;
                result = Expression.Call(null, method.Method, _date, Expression.Constant(_days.ToArray()));
            }
            else
            {
                var e = context.expression_bool();
                if (e != null)
                    result = VisitExpression_bool(e);
                else
                {
                    if (System.Diagnostics.Debugger.IsAttached)
                        System.Diagnostics.Debugger.Break();
                }
            }

            return result;
        }

        /// <summary>
        ///   rule expression?
        /// | LEFT_PAREN expression RIGHT_PAREN expression?
        /// | NOT expression expression?
        /// | operation expression
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Expression VisitExpression([NotNull] CalendariumParser.ExpressionContext context)
        {
            Expression left = null;

            var debug = context.GetText();

            var e = context.expression();
            var rule = context.rule();

            if (rule != null)
            {

                left = VisitRule(rule);

                if (e.Length == 1)
                {
                    _stack.Push(left);
                    left = VisitExpression(e[0]);
                }

            }
            else
            {
                if (context.LEFT_PAREN() != null)
                {
                    left = VisitExpression(e[0]);
                    if (e.Length == 2)
                    {
                        _stack.Push(left);
                        var t = _stack.Count;
                        left = VisitExpression(e[1]);
                        if (t == _stack.Count)
                        {
                            System.Diagnostics.Debugger.Break();
                        }
                    }
                }
                else
                {
                    var operation = context.operation();
                    if (operation != null)
                    {
                        left = _stack.Pop();
                        var ope = operation.GetText();
                        var right = VisitExpression(e[0]);
                        left = Visit(left, ope, right);
                    }
                    else
                    {
                        System.Diagnostics.Debugger.Break();
                    }
                }
            }

            return left;

        }

        private Expression Visit(Expression left, string operation, Expression right)
        {

            if (left.Type.IsArray)
            {
                switch (operation)
                {

                    case ">>":
                        return Expression.Call(null, ParserBaseVisitor._methodNextDays, left, right);

                    case "<<":
                        return Expression.Call(null, ParserBaseVisitor._methodBackDays, left, right);

                    case "+":
                        return Expression.Call(null, ParserBaseVisitor._methodAddDays, left, right);

                    case "-":
                        ConstantExpression value = (ConstantExpression)right;
                        if (right is ConstantExpression c)
                            value = Expression.Constant(0 - (int)c.Value);
                        return Expression.Call(ParserBaseVisitor._methodAddDays, left, value);

                    default:
                        if (System.Diagnostics.Debugger.IsAttached)
                            System.Diagnostics.Debugger.Break();
                        throw new NotImplementedException();
                }
            }
            else
            {
                switch (operation)
                {

                    case ">>":
                        return Expression.Call(null, ParserBaseVisitor._methodNextDay, left, right);

                    case "<<":
                        return Expression.Call(null, ParserBaseVisitor._methodBackDay, left, right);

                    case "+":
                        return Expression.Call(null, ParserBaseVisitor._methodAddDay, left, right);

                    case "-":
                        ConstantExpression value = (ConstantExpression)right;
                        if (right is ConstantExpression c)
                            value = Expression.Constant(0 - (int)c.Value);
                        return Expression.Call(ParserBaseVisitor._methodAddDay, left, value);

                    default:
                        if (System.Diagnostics.Debugger.IsAttached)
                            System.Diagnostics.Debugger.Break();
                        throw new NotImplementedException();
                }
            }

        }

        /// <summary>
        ///   mask
        /// | LEFT_BRACKET identifier RIGHT_BRACKET
        /// | dayweek
        /// | NUMBER
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Expression VisitRule([NotNull] CalendariumParser.RuleContext context)
        {

            Expression resultExpression = null;

            var date = context.mask();
            if (date != null)
                resultExpression = (MethodCallExpression)VisitMask(date); // convert only for lisibility

            else
            {

                var identifier = context.identifier();
                if (identifier != null)
                    resultExpression = (MethodCallExpression)VisitIdentifier(identifier); // convert only for lisibility

                else
                {

                    var day = context.dayweek();
                    if (day != null)
                    {

                        resultExpression = (ConstantExpression)VisitDayweek(day);

                        if (context.TIME() != null)
                            resultExpression = Expression.Call(null, ParserBaseVisitor._methodDayOfWeek, _year, resultExpression);

                    }
                    else
                    {

                        var n = context.NUMBER();
                        if (n != null)
                        {
                            var i = int.Parse(n.GetText());
                            resultExpression = Expression.Constant(i);
                        }
                        else
                            throw new NotImplementedException(context.GetText());
                    }
                }
            }

            return resultExpression;

        }

        /// <summary>
        ///  month=NUMBER SLASH day=NUMBER
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Expression VisitMask([NotNull] CalendariumParser.MaskContext context)
        {

            var month = (ConstantExpression)VisitDateItem(context.month.Text);
            var day = (ConstantExpression)VisitDateItem(context.day.Text);

            Func<int, int, int, System.Globalization.Calendar, DateTime[]> function = FunctionHelpers.Mask;
            var method = Expression.Call(null, function.Method, _year, month, day, Expression.Constant(Calendar));

            return method;

        }

        /// <summary>
        /// TIME | NUMBER
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Expression VisitDateItem(string value)
        {
            var i = int.Parse(value);
            return Expression.Constant(i);
        }

        /// <summary>
        /// REGULAR_ID
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Expression VisitIdentifier([NotNull] CalendariumParser.IdentifierContext context)
        {

            Func<int, DateTime[]> function = null;

            var label = context.REGULAR_ID().GetText();

            switch (label)
            {

                case "EASTER":
                    function = FunctionHelpers.Easter;
                    break;

                case "ORTHODOX_EASTER":
                    function = FunctionHelpers.OrthodoxEaster;
                    break;

                default:
                    if (System.Diagnostics.Debugger.IsAttached)
                        System.Diagnostics.Debugger.Break();
                    throw new NotImplementedException(label);
            }

            return Expression.Call(null, function.Method, _year);

        }


        /// <summary>
        ///  MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY | SATURDAY | SUNDAY
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Expression VisitDayweek([NotNull] CalendariumParser.DayweekContext context)
        {

            ConstantExpression arg = null;

            if (context.MONDAY() != null)
                arg = Expression.Constant(DayOfWeek.Monday);

            else if (context.TUESDAY() != null)
                arg = Expression.Constant(DayOfWeek.Tuesday);

            else if (context.WEDNESDAY() != null)
                arg = Expression.Constant(DayOfWeek.Wednesday);

            else if (context.THURSDAY() != null)
                arg = Expression.Constant(DayOfWeek.Thursday);

            else if (context.FRIDAY() != null)
                arg = Expression.Constant(DayOfWeek.Friday);

            else if (context.SATURDAY() != null)
                arg = Expression.Constant(DayOfWeek.Saturday);

            else if (context.SUNDAY() != null)
                arg = Expression.Constant(DayOfWeek.Sunday);
            else
                throw new NotImplementedException(context.GetText());

            return arg;

        }

        public Calendar Calendar { get; }

        private readonly Stack<Expression> _stack;
        private readonly ParameterExpression _year;

        public ParameterExpression _date { get; }

        private static readonly MethodInfo _methodAddDay;
        private static readonly MethodInfo _methodAddDays;

        private static readonly MethodInfo _methodBackDay;
        private static readonly MethodInfo _methodNextDay;

        private static readonly MethodInfo _methodBackDays;
        private static readonly MethodInfo _methodNextDays;
        private static readonly MethodInfo _methodDayOfWeek;
    }

}
