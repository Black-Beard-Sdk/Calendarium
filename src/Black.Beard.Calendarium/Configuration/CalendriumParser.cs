using Antlr4.Runtime;
using Bb.Calendarium.Configuration;
using Bb.Calendaruim.Parser;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;

namespace Bb.Calendarium
{

    internal class CalendriumParser
    {

        public CalendriumParser(TextWriter output, TextWriter outputError)
        {
            Output = output ?? Console.Out;
            OutputError = outputError ?? Console.Error;
            this._delegateLogDebug = Bb.Calendarium.Configuration.CountryDebugger.Debug;
            this._delegateLogDebugObserved = Bb.Calendarium.Configuration.CountryDebugger.DebugObserved;
        }

        public Func<int, DateTime[]> ParseRuleString(string source, string dayName, string country, Calendar calendar)
        {

            ICharStream stream = CharStreams.fromstring(source);

            var lexer = new CalendariumLexer(stream, Output, OutputError);
            var token = new CommonTokenStream(lexer);
            var _parser = new CalendariumParser(token)
            {
                BuildParseTree = true,
                //Trace = ScriptParser.Trace, // Ca plante sur un null, pourquoi ?
            };

            CalendariumParser.ScriptContext _context = _parser.script();

            var visitor = new ParserBaseVisitor(calendar);

            var call = (Expression<Func<int, DateTime[]>>)visitor.Visit(_context);

            var txt = "'" + source + "' -> '" + call.Body.ToString() + "'";
            Trace.WriteLine($"{country.ToString()}:{dayName} : {txt}");

            if (System.Diagnostics.Debugger.IsAttached) // Build an interceptor for log
            {
                var parameter = Expression.Parameter(typeof(int), "year");
                var ee = Expression.Call(null, _delegateLogDebug.Method, call, parameter, Expression.Constant(country), Expression.Constant(dayName), Expression.Constant(txt));
                call = Expression.Lambda<Func<int, DateTime[]>>(ee, parameter);
            }
            Func<int, DateTime[]> f = call.Compile();


            return f;

        }

        public Func<DateTime, DateTime> ParseRuleObservedString(string source, string dayName, string country, Calendar calendar)
        {

            ICharStream stream = CharStreams.fromstring(source);

            var lexer = new CalendariumLexer(stream, Output, OutputError);
            var token = new CommonTokenStream(lexer);
            var _parser = new CalendariumParser(token)
            {
                BuildParseTree = true,
                //Trace = ScriptParser.Trace, // Ca plante sur un null, pourquoi ?
            };

            CalendariumParser.ScriptContext _context = _parser.script();

            var visitor = new ParserBaseVisitor(calendar);

            var call = (Expression<Func<DateTime, DateTime>>)visitor.Visit(_context);

            var txt = "'" + source + "' -> '" + call.Body.ToString() + "'";
            Trace.WriteLine($"{country.ToString()}:{dayName} : {txt}");

            if (System.Diagnostics.Debugger.IsAttached) // Build an interceptor for log
            {
                var parameter = Expression.Parameter(typeof(DateTime), "date");
                var ee = Expression.Call(null, _delegateLogDebugObserved.Method, call, parameter, Expression.Constant(country), Expression.Constant(dayName), Expression.Constant(txt));
                call = Expression.Lambda<Func<DateTime, DateTime>>(ee, parameter);
            }
            Func<DateTime, DateTime> f = call.Compile();


            return f;

        }

        public TextWriter Output { get; private set; }

        public TextWriter OutputError { get; private set; }


        private Func<Func<int, DateTime[]>, int, string, string, string, DateTime[]> _delegateLogDebug;
        private Func<Func<DateTime, DateTime>, DateTime, string, string, string, DateTime> _delegateLogDebugObserved;

    }

}
