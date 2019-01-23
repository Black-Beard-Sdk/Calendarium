using Antlr4.Runtime;
using Bb.Calendarium.Configuration;
using Bb.Calendaruim.Parser;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;

namespace Bb.Calendarium
{

    public class CalendriumParser
    {

        public CalendriumParser(TextWriter output, TextWriter outputError)
        {
            Output = output ?? Console.Out;
            OutputError = outputError ?? Console.Error;
            this._delegateLogDebug = Bb.Calendarium.Configuration.CountryDebugger.Debug;
        }

        public Func<int, DateTime[]> ParseRuleString(string source, string dayName, Country country)
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

            var visitor = new ParserBaseVisitor();

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


        public TextWriter Output { get; private set; }

        public TextWriter OutputError { get; private set; }


        private Func<Func<int, DateTime[]>, int, Country, string, string, DateTime[]> _delegateLogDebug;

    }

}
