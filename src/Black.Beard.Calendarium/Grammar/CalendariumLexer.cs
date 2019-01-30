//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CalendariumLexer.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Bb.Calendaruim.Parser {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class CalendariumLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		YEAR=1, MONTH=2, DAY=3, DAYWEEK=4, MONDAY=5, TUESDAY=6, WEDNESDAY=7, THURSDAY=8, 
		FRIDAY=9, SATURDAY=10, SUNDAY=11, CHAR_STRING=12, LEFT_PAREN=13, LEFT_BRACKET=14, 
		RIGHT_PAREN=15, RIGHT_BRACKET=16, COLON=17, SEMICOLON=18, COMMA=19, PLUS=20, 
		MINUS=21, TIME=22, DOT=23, DIVID=24, NOT=25, EQUAL=26, MODULO=27, POWER=28, 
		NOT_EQUAL=29, GREATER=30, GREATER_OR_EQUAL=31, LESS=32, LESS_OR_EQUAL=33, 
		XOR=34, OR=35, AND=36, ANDALSO=37, SLASH=38, INTEROGATION=39, SPACES=40, 
		NUMBER=41, SINGLE_LINE_COMMENT=42, MULTI_LINE_COMMENT=43, REGULAR_ID=44;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"YEAR", "MONTH", "DAY", "DAYWEEK", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", 
		"FRIDAY", "SATURDAY", "SUNDAY", "CHAR_STRING", "LEFT_PAREN", "LEFT_BRACKET", 
		"RIGHT_PAREN", "RIGHT_BRACKET", "COLON", "SEMICOLON", "COMMA", "PLUS", 
		"MINUS", "TIME", "DOT", "DIVID", "NOT", "EQUAL", "MODULO", "POWER", "NOT_EQUAL", 
		"GREATER", "GREATER_OR_EQUAL", "LESS", "LESS_OR_EQUAL", "XOR", "OR", "AND", 
		"ANDALSO", "SLASH", "INTEROGATION", "SPACES", "SIMPLE_LETTER", "NUMBER", 
		"SINGLE_LINE_COMMENT", "MULTI_LINE_COMMENT", "SPACE", "REGULAR_ID"
	};


	public CalendariumLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CalendariumLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'YEAR'", "'MONTH'", "'DAY'", "'DAYWEEK'", "'MONDAY'", "'TUESDAY'", 
		"'WEDNESDAY'", "'THURSDAY'", "'FRIDAY'", "'SATURDAY'", "'SUNDAY'", null, 
		"'('", "'['", "')'", "']'", "':'", "';'", "','", "'+'", "'-'", "'*'", 
		"'.'", null, "'!'", "'='", "'%'", "'^'", "'!='", "'>'", "'>='", "'<'", 
		"'<='", "'||'", "'|'", "'&'", "'&&'", null, "'?'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "YEAR", "MONTH", "DAY", "DAYWEEK", "MONDAY", "TUESDAY", "WEDNESDAY", 
		"THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY", "CHAR_STRING", "LEFT_PAREN", 
		"LEFT_BRACKET", "RIGHT_PAREN", "RIGHT_BRACKET", "COLON", "SEMICOLON", 
		"COMMA", "PLUS", "MINUS", "TIME", "DOT", "DIVID", "NOT", "EQUAL", "MODULO", 
		"POWER", "NOT_EQUAL", "GREATER", "GREATER_OR_EQUAL", "LESS", "LESS_OR_EQUAL", 
		"XOR", "OR", "AND", "ANDALSO", "SLASH", "INTEROGATION", "SPACES", "NUMBER", 
		"SINGLE_LINE_COMMENT", "MULTI_LINE_COMMENT", "REGULAR_ID"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CalendariumLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CalendariumLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '.', '\x127', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x6', '\r', 
		'\xB4', '\n', '\r', '\r', '\r', '\xE', '\r', '\xB5', '\x3', '\r', '\x3', 
		'\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', 
		'!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', 
		'#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', 
		'&', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', 
		'(', '\x3', ')', '\x6', ')', '\xF6', '\n', ')', '\r', ')', '\xE', ')', 
		'\xF7', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', '*', '\x3', '+', '\x6', 
		'+', '\xFF', '\n', '+', '\r', '+', '\xE', '+', '\x100', '\x3', ',', '\x3', 
		',', '\x3', ',', '\x3', ',', '\a', ',', '\x107', '\n', ',', '\f', ',', 
		'\xE', ',', '\x10A', '\v', ',', '\x3', ',', '\x3', ',', '\x3', ',', '\x3', 
		',', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', '-', '\a', '-', '\x114', 
		'\n', '-', '\f', '-', '\xE', '-', '\x117', '\v', '-', '\x3', '-', '\x3', 
		'-', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', '.', '\x3', '.', '\x3', 
		'/', '\x3', '/', '\x3', '/', '\a', '/', '\x123', '\n', '/', '\f', '/', 
		'\xE', '/', '\x126', '\v', '/', '\x3', '\x115', '\x2', '\x30', '\x3', 
		'\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', 
		'\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', 
		'*', 'S', '\x2', 'U', '+', 'W', ',', 'Y', '-', '[', '\x2', ']', '.', '\x3', 
		'\x2', '\t', '\x5', '\x2', '\f', '\f', '\xF', '\xF', ')', ')', '\x5', 
		'\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', '\x2', '\x43', '\\', 
		'\x63', '|', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '\f', '\f', '\xF', 
		'\xF', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x5', '\x2', '%', '&', '\x32', 
		';', '\x61', '\x61', '\x2', '\x12C', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x2', ']', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '_', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x64', '\x3', '\x2', '\x2', '\x2', '\a', 'j', '\x3', '\x2', '\x2', '\x2', 
		'\t', 'n', '\x3', '\x2', '\x2', '\x2', '\v', 'v', '\x3', '\x2', '\x2', 
		'\x2', '\r', '}', '\x3', '\x2', '\x2', '\x2', '\xF', '\x85', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x13', '\x98', 
		'\x3', '\x2', '\x2', '\x2', '\x15', '\x9F', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '\xA8', '\x3', '\x2', '\x2', '\x2', '\x19', '\xAF', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', '\xB9', '\x3', '\x2', '\x2', '\x2', '\x1D', '\xBB', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', '\xBD', '\x3', '\x2', '\x2', '\x2', 
		'!', '\xBF', '\x3', '\x2', '\x2', '\x2', '#', '\xC1', '\x3', '\x2', '\x2', 
		'\x2', '%', '\xC3', '\x3', '\x2', '\x2', '\x2', '\'', '\xC5', '\x3', '\x2', 
		'\x2', '\x2', ')', '\xC7', '\x3', '\x2', '\x2', '\x2', '+', '\xC9', '\x3', 
		'\x2', '\x2', '\x2', '-', '\xCB', '\x3', '\x2', '\x2', '\x2', '/', '\xCD', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\xCF', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\xD1', '\x3', '\x2', '\x2', '\x2', '\x35', '\xD3', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\xD5', '\x3', '\x2', '\x2', '\x2', '\x39', '\xD7', 
		'\x3', '\x2', '\x2', '\x2', ';', '\xD9', '\x3', '\x2', '\x2', '\x2', '=', 
		'\xDC', '\x3', '\x2', '\x2', '\x2', '?', '\xDE', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\xE1', '\x3', '\x2', '\x2', '\x2', '\x43', '\xE3', '\x3', 
		'\x2', '\x2', '\x2', '\x45', '\xE6', '\x3', '\x2', '\x2', '\x2', 'G', 
		'\xE9', '\x3', '\x2', '\x2', '\x2', 'I', '\xEB', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\xED', '\x3', '\x2', '\x2', '\x2', 'M', '\xF0', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\xF2', '\x3', '\x2', '\x2', '\x2', 'Q', '\xF5', '\x3', 
		'\x2', '\x2', '\x2', 'S', '\xFB', '\x3', '\x2', '\x2', '\x2', 'U', '\xFE', 
		'\x3', '\x2', '\x2', '\x2', 'W', '\x102', '\x3', '\x2', '\x2', '\x2', 
		'Y', '\x10F', '\x3', '\x2', '\x2', '\x2', '[', '\x11D', '\x3', '\x2', 
		'\x2', '\x2', ']', '\x11F', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', 
		'[', '\x2', '\x2', '`', '\x61', '\a', 'G', '\x2', '\x2', '\x61', '\x62', 
		'\a', '\x43', '\x2', '\x2', '\x62', '\x63', '\a', 'T', '\x2', '\x2', '\x63', 
		'\x4', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\a', 'O', '\x2', '\x2', 
		'\x65', '\x66', '\a', 'Q', '\x2', '\x2', '\x66', 'g', '\a', 'P', '\x2', 
		'\x2', 'g', 'h', '\a', 'V', '\x2', '\x2', 'h', 'i', '\a', 'J', '\x2', 
		'\x2', 'i', '\x6', '\x3', '\x2', '\x2', '\x2', 'j', 'k', '\a', '\x46', 
		'\x2', '\x2', 'k', 'l', '\a', '\x43', '\x2', '\x2', 'l', 'm', '\a', '[', 
		'\x2', '\x2', 'm', '\b', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '\x46', 
		'\x2', '\x2', 'o', 'p', '\a', '\x43', '\x2', '\x2', 'p', 'q', '\a', '[', 
		'\x2', '\x2', 'q', 'r', '\a', 'Y', '\x2', '\x2', 'r', 's', '\a', 'G', 
		'\x2', '\x2', 's', 't', '\a', 'G', '\x2', '\x2', 't', 'u', '\a', 'M', 
		'\x2', '\x2', 'u', '\n', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', 'O', 
		'\x2', '\x2', 'w', 'x', '\a', 'Q', '\x2', '\x2', 'x', 'y', '\a', 'P', 
		'\x2', '\x2', 'y', 'z', '\a', '\x46', '\x2', '\x2', 'z', '{', '\a', '\x43', 
		'\x2', '\x2', '{', '|', '\a', '[', '\x2', '\x2', '|', '\f', '\x3', '\x2', 
		'\x2', '\x2', '}', '~', '\a', 'V', '\x2', '\x2', '~', '\x7F', '\a', 'W', 
		'\x2', '\x2', '\x7F', '\x80', '\a', 'G', '\x2', '\x2', '\x80', '\x81', 
		'\a', 'U', '\x2', '\x2', '\x81', '\x82', '\a', '\x46', '\x2', '\x2', '\x82', 
		'\x83', '\a', '\x43', '\x2', '\x2', '\x83', '\x84', '\a', '[', '\x2', 
		'\x2', '\x84', '\xE', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', 
		'Y', '\x2', '\x2', '\x86', '\x87', '\a', 'G', '\x2', '\x2', '\x87', '\x88', 
		'\a', '\x46', '\x2', '\x2', '\x88', '\x89', '\a', 'P', '\x2', '\x2', '\x89', 
		'\x8A', '\a', 'G', '\x2', '\x2', '\x8A', '\x8B', '\a', 'U', '\x2', '\x2', 
		'\x8B', '\x8C', '\a', '\x46', '\x2', '\x2', '\x8C', '\x8D', '\a', '\x43', 
		'\x2', '\x2', '\x8D', '\x8E', '\a', '[', '\x2', '\x2', '\x8E', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', 'V', '\x2', '\x2', '\x90', 
		'\x91', '\a', 'J', '\x2', '\x2', '\x91', '\x92', '\a', 'W', '\x2', '\x2', 
		'\x92', '\x93', '\a', 'T', '\x2', '\x2', '\x93', '\x94', '\a', 'U', '\x2', 
		'\x2', '\x94', '\x95', '\a', '\x46', '\x2', '\x2', '\x95', '\x96', '\a', 
		'\x43', '\x2', '\x2', '\x96', '\x97', '\a', '[', '\x2', '\x2', '\x97', 
		'\x12', '\x3', '\x2', '\x2', '\x2', '\x98', '\x99', '\a', 'H', '\x2', 
		'\x2', '\x99', '\x9A', '\a', 'T', '\x2', '\x2', '\x9A', '\x9B', '\a', 
		'K', '\x2', '\x2', '\x9B', '\x9C', '\a', '\x46', '\x2', '\x2', '\x9C', 
		'\x9D', '\a', '\x43', '\x2', '\x2', '\x9D', '\x9E', '\a', '[', '\x2', 
		'\x2', '\x9E', '\x14', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\a', 
		'U', '\x2', '\x2', '\xA0', '\xA1', '\a', '\x43', '\x2', '\x2', '\xA1', 
		'\xA2', '\a', 'V', '\x2', '\x2', '\xA2', '\xA3', '\a', 'W', '\x2', '\x2', 
		'\xA3', '\xA4', '\a', 'T', '\x2', '\x2', '\xA4', '\xA5', '\a', '\x46', 
		'\x2', '\x2', '\xA5', '\xA6', '\a', '\x43', '\x2', '\x2', '\xA6', '\xA7', 
		'\a', '[', '\x2', '\x2', '\xA7', '\x16', '\x3', '\x2', '\x2', '\x2', '\xA8', 
		'\xA9', '\a', 'U', '\x2', '\x2', '\xA9', '\xAA', '\a', 'W', '\x2', '\x2', 
		'\xAA', '\xAB', '\a', 'P', '\x2', '\x2', '\xAB', '\xAC', '\a', '\x46', 
		'\x2', '\x2', '\xAC', '\xAD', '\a', '\x43', '\x2', '\x2', '\xAD', '\xAE', 
		'\a', '[', '\x2', '\x2', '\xAE', '\x18', '\x3', '\x2', '\x2', '\x2', '\xAF', 
		'\xB3', '\a', ')', '\x2', '\x2', '\xB0', '\xB4', '\n', '\x2', '\x2', '\x2', 
		'\xB1', '\xB2', '\a', ')', '\x2', '\x2', '\xB2', '\xB4', '\a', ')', '\x2', 
		'\x2', '\xB3', '\xB0', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB1', '\x3', 
		'\x2', '\x2', '\x2', '\xB4', '\xB5', '\x3', '\x2', '\x2', '\x2', '\xB5', 
		'\xB3', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\x3', '\x2', '\x2', 
		'\x2', '\xB6', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB8', '\a', 
		')', '\x2', '\x2', '\xB8', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xB9', 
		'\xBA', '\a', '*', '\x2', '\x2', '\xBA', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\xBB', '\xBC', '\a', ']', '\x2', '\x2', '\xBC', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\xBD', '\xBE', '\a', '+', '\x2', '\x2', '\xBE', 
		' ', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xC0', '\a', '_', '\x2', '\x2', 
		'\xC0', '\"', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xC2', '\a', '<', '\x2', 
		'\x2', '\xC2', '$', '\x3', '\x2', '\x2', '\x2', '\xC3', '\xC4', '\a', 
		'=', '\x2', '\x2', '\xC4', '&', '\x3', '\x2', '\x2', '\x2', '\xC5', '\xC6', 
		'\a', '.', '\x2', '\x2', '\xC6', '(', '\x3', '\x2', '\x2', '\x2', '\xC7', 
		'\xC8', '\a', '-', '\x2', '\x2', '\xC8', '*', '\x3', '\x2', '\x2', '\x2', 
		'\xC9', '\xCA', '\a', '/', '\x2', '\x2', '\xCA', ',', '\x3', '\x2', '\x2', 
		'\x2', '\xCB', '\xCC', '\a', ',', '\x2', '\x2', '\xCC', '.', '\x3', '\x2', 
		'\x2', '\x2', '\xCD', '\xCE', '\a', '\x30', '\x2', '\x2', '\xCE', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', '\a', '^', '\x2', '\x2', '\xD0', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD2', '\a', '#', '\x2', 
		'\x2', '\xD2', '\x34', '\x3', '\x2', '\x2', '\x2', '\xD3', '\xD4', '\a', 
		'?', '\x2', '\x2', '\xD4', '\x36', '\x3', '\x2', '\x2', '\x2', '\xD5', 
		'\xD6', '\a', '\'', '\x2', '\x2', '\xD6', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\xD7', '\xD8', '\a', '`', '\x2', '\x2', '\xD8', ':', '\x3', '\x2', 
		'\x2', '\x2', '\xD9', '\xDA', '\a', '#', '\x2', '\x2', '\xDA', '\xDB', 
		'\a', '?', '\x2', '\x2', '\xDB', '<', '\x3', '\x2', '\x2', '\x2', '\xDC', 
		'\xDD', '\a', '@', '\x2', '\x2', '\xDD', '>', '\x3', '\x2', '\x2', '\x2', 
		'\xDE', '\xDF', '\a', '@', '\x2', '\x2', '\xDF', '\xE0', '\a', '?', '\x2', 
		'\x2', '\xE0', '@', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', '\a', 
		'>', '\x2', '\x2', '\xE2', '\x42', '\x3', '\x2', '\x2', '\x2', '\xE3', 
		'\xE4', '\a', '>', '\x2', '\x2', '\xE4', '\xE5', '\a', '?', '\x2', '\x2', 
		'\xE5', '\x44', '\x3', '\x2', '\x2', '\x2', '\xE6', '\xE7', '\a', '~', 
		'\x2', '\x2', '\xE7', '\xE8', '\a', '~', '\x2', '\x2', '\xE8', '\x46', 
		'\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\a', '~', '\x2', '\x2', '\xEA', 
		'H', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\a', '(', '\x2', '\x2', 
		'\xEC', 'J', '\x3', '\x2', '\x2', '\x2', '\xED', '\xEE', '\a', '(', '\x2', 
		'\x2', '\xEE', '\xEF', '\a', '(', '\x2', '\x2', '\xEF', 'L', '\x3', '\x2', 
		'\x2', '\x2', '\xF0', '\xF1', '\a', '^', '\x2', '\x2', '\xF1', 'N', '\x3', 
		'\x2', '\x2', '\x2', '\xF2', '\xF3', '\a', '\x41', '\x2', '\x2', '\xF3', 
		'P', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF6', '\t', '\x3', '\x2', '\x2', 
		'\xF5', '\xF4', '\x3', '\x2', '\x2', '\x2', '\xF6', '\xF7', '\x3', '\x2', 
		'\x2', '\x2', '\xF7', '\xF5', '\x3', '\x2', '\x2', '\x2', '\xF7', '\xF8', 
		'\x3', '\x2', '\x2', '\x2', '\xF8', '\xF9', '\x3', '\x2', '\x2', '\x2', 
		'\xF9', '\xFA', '\b', ')', '\x2', '\x2', '\xFA', 'R', '\x3', '\x2', '\x2', 
		'\x2', '\xFB', '\xFC', '\t', '\x4', '\x2', '\x2', '\xFC', 'T', '\x3', 
		'\x2', '\x2', '\x2', '\xFD', '\xFF', '\t', '\x5', '\x2', '\x2', '\xFE', 
		'\xFD', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x100', '\x3', '\x2', '\x2', 
		'\x2', '\x100', '\xFE', '\x3', '\x2', '\x2', '\x2', '\x100', '\x101', 
		'\x3', '\x2', '\x2', '\x2', '\x101', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\x102', '\x103', '\a', '/', '\x2', '\x2', '\x103', '\x104', '\a', '/', 
		'\x2', '\x2', '\x104', '\x108', '\x3', '\x2', '\x2', '\x2', '\x105', '\x107', 
		'\n', '\x6', '\x2', '\x2', '\x106', '\x105', '\x3', '\x2', '\x2', '\x2', 
		'\x107', '\x10A', '\x3', '\x2', '\x2', '\x2', '\x108', '\x106', '\x3', 
		'\x2', '\x2', '\x2', '\x108', '\x109', '\x3', '\x2', '\x2', '\x2', '\x109', 
		'\x10B', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x108', '\x3', '\x2', '\x2', 
		'\x2', '\x10B', '\x10C', '\a', '\x2', '\x2', '\x3', '\x10C', '\x10D', 
		'\x3', '\x2', '\x2', '\x2', '\x10D', '\x10E', '\b', ',', '\x3', '\x2', 
		'\x10E', 'X', '\x3', '\x2', '\x2', '\x2', '\x10F', '\x110', '\a', '\x31', 
		'\x2', '\x2', '\x110', '\x111', '\a', ',', '\x2', '\x2', '\x111', '\x115', 
		'\x3', '\x2', '\x2', '\x2', '\x112', '\x114', '\v', '\x2', '\x2', '\x2', 
		'\x113', '\x112', '\x3', '\x2', '\x2', '\x2', '\x114', '\x117', '\x3', 
		'\x2', '\x2', '\x2', '\x115', '\x116', '\x3', '\x2', '\x2', '\x2', '\x115', 
		'\x113', '\x3', '\x2', '\x2', '\x2', '\x116', '\x118', '\x3', '\x2', '\x2', 
		'\x2', '\x117', '\x115', '\x3', '\x2', '\x2', '\x2', '\x118', '\x119', 
		'\a', ',', '\x2', '\x2', '\x119', '\x11A', '\a', '\x31', '\x2', '\x2', 
		'\x11A', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x11B', '\x11C', '\b', 
		'-', '\x3', '\x2', '\x11C', 'Z', '\x3', '\x2', '\x2', '\x2', '\x11D', 
		'\x11E', '\t', '\a', '\x2', '\x2', '\x11E', '\\', '\x3', '\x2', '\x2', 
		'\x2', '\x11F', '\x124', '\x5', 'S', '*', '\x2', '\x120', '\x123', '\x5', 
		'S', '*', '\x2', '\x121', '\x123', '\t', '\b', '\x2', '\x2', '\x122', 
		'\x120', '\x3', '\x2', '\x2', '\x2', '\x122', '\x121', '\x3', '\x2', '\x2', 
		'\x2', '\x123', '\x126', '\x3', '\x2', '\x2', '\x2', '\x124', '\x122', 
		'\x3', '\x2', '\x2', '\x2', '\x124', '\x125', '\x3', '\x2', '\x2', '\x2', 
		'\x125', '^', '\x3', '\x2', '\x2', '\x2', '\x126', '\x124', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x2', '\xB3', '\xB5', '\xF7', '\x100', '\x108', '\x115', 
		'\x122', '\x124', '\x4', '\b', '\x2', '\x2', '\x2', '\x3', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Bb.Calendaruim.Parser
