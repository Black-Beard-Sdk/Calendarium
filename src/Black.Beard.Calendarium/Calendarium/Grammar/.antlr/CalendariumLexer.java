// Generated from d:\Src\Calendarium\src\Black.Beard.Calendarium\Calendarium\Grammar/CalendariumLexer.g4 by ANTLR 4.7.1
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class CalendariumLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		YEAR=1, MONTH=2, DAY=3, DAYWEEK=4, MONDAY=5, TUESDAY=6, WEDNESDAY=7, THURSDAY=8, 
		FRIDAY=9, SATURDAY=10, SUNDAY=11, CHAR_STRING=12, LEFT_PAREN=13, LEFT_BRACKET=14, 
		RIGHT_PAREN=15, RIGHT_BRACKET=16, COLON=17, SEMICOLON=18, COMMA=19, PLUS=20, 
		MINUS=21, TIME=22, DOT=23, DIVID=24, NOT=25, EQUAL=26, MODULO=27, POWER=28, 
		NOT_EQUAL=29, GREATER=30, GREATER_OR_EQUAL=31, LESS=32, LESS_OR_EQUAL=33, 
		XOR=34, OR=35, AND=36, ANDALSO=37, SLASH=38, INTEROGATION=39, SPACES=40, 
		NUMBER=41, SINGLE_LINE_COMMENT=42, MULTI_LINE_COMMENT=43, REGULAR_ID=44;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] ruleNames = {
		"YEAR", "MONTH", "DAY", "DAYWEEK", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", 
		"FRIDAY", "SATURDAY", "SUNDAY", "CHAR_STRING", "LEFT_PAREN", "LEFT_BRACKET", 
		"RIGHT_PAREN", "RIGHT_BRACKET", "COLON", "SEMICOLON", "COMMA", "PLUS", 
		"MINUS", "TIME", "DOT", "DIVID", "NOT", "EQUAL", "MODULO", "POWER", "NOT_EQUAL", 
		"GREATER", "GREATER_OR_EQUAL", "LESS", "LESS_OR_EQUAL", "XOR", "OR", "AND", 
		"ANDALSO", "SLASH", "INTEROGATION", "SPACES", "SIMPLE_LETTER", "NUMBER", 
		"SINGLE_LINE_COMMENT", "MULTI_LINE_COMMENT", "SPACE", "REGULAR_ID"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'YEAR'", "'MONTH'", "'DAY'", "'DAYWEEK'", "'MONDAY'", "'TUESDAY'", 
		"'WEDNESDAY'", "'THURSDAY'", "'FRIDAY'", "'SATURDAY'", "'SUNDAY'", null, 
		"'('", "'['", "')'", "']'", "':'", "';'", "','", "'+'", "'-'", "'*'", 
		"'.'", null, "'!'", "'='", "'%'", "'^'", "'!='", "'>'", "'>='", "'<'", 
		"'<='", "'||'", "'|'", "'&'", "'&&'", null, "'?'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, "YEAR", "MONTH", "DAY", "DAYWEEK", "MONDAY", "TUESDAY", "WEDNESDAY", 
		"THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY", "CHAR_STRING", "LEFT_PAREN", 
		"LEFT_BRACKET", "RIGHT_PAREN", "RIGHT_BRACKET", "COLON", "SEMICOLON", 
		"COMMA", "PLUS", "MINUS", "TIME", "DOT", "DIVID", "NOT", "EQUAL", "MODULO", 
		"POWER", "NOT_EQUAL", "GREATER", "GREATER_OR_EQUAL", "LESS", "LESS_OR_EQUAL", 
		"XOR", "OR", "AND", "ANDALSO", "SLASH", "INTEROGATION", "SPACES", "NUMBER", 
		"SINGLE_LINE_COMMENT", "MULTI_LINE_COMMENT", "REGULAR_ID"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public CalendariumLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "CalendariumLexer.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2.\u0127\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\4/\t/\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\3\3\4"+
		"\3\4\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\6\3"+
		"\6\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b"+
		"\3\b\3\t\3\t\3\t\3\t\3\t\3\t\3\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3"+
		"\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\3"+
		"\f\3\r\3\r\3\r\3\r\6\r\u00b4\n\r\r\r\16\r\u00b5\3\r\3\r\3\16\3\16\3\17"+
		"\3\17\3\20\3\20\3\21\3\21\3\22\3\22\3\23\3\23\3\24\3\24\3\25\3\25\3\26"+
		"\3\26\3\27\3\27\3\30\3\30\3\31\3\31\3\32\3\32\3\33\3\33\3\34\3\34\3\35"+
		"\3\35\3\36\3\36\3\36\3\37\3\37\3 \3 \3 \3!\3!\3\"\3\"\3\"\3#\3#\3#\3$"+
		"\3$\3%\3%\3&\3&\3&\3\'\3\'\3(\3(\3)\6)\u00f6\n)\r)\16)\u00f7\3)\3)\3*"+
		"\3*\3+\6+\u00ff\n+\r+\16+\u0100\3,\3,\3,\3,\7,\u0107\n,\f,\16,\u010a\13"+
		",\3,\3,\3,\3,\3-\3-\3-\3-\7-\u0114\n-\f-\16-\u0117\13-\3-\3-\3-\3-\3-"+
		"\3.\3.\3/\3/\3/\7/\u0123\n/\f/\16/\u0126\13/\3\u0115\2\60\3\3\5\4\7\5"+
		"\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23"+
		"%\24\'\25)\26+\27-\30/\31\61\32\63\33\65\34\67\359\36;\37= ?!A\"C#E$G"+
		"%I&K\'M(O)Q*S\2U+W,Y-[\2].\3\2\t\5\2\f\f\17\17))\5\2\13\f\17\17\"\"\4"+
		"\2C\\c|\3\2\62;\4\2\f\f\17\17\4\2\13\13\"\"\5\2%&\62;aa\2\u012c\2\3\3"+
		"\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2"+
		"\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3"+
		"\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2"+
		"%\3\2\2\2\2\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61"+
		"\3\2\2\2\2\63\3\2\2\2\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2"+
		"\2=\3\2\2\2\2?\3\2\2\2\2A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2I"+
		"\3\2\2\2\2K\3\2\2\2\2M\3\2\2\2\2O\3\2\2\2\2Q\3\2\2\2\2U\3\2\2\2\2W\3\2"+
		"\2\2\2Y\3\2\2\2\2]\3\2\2\2\3_\3\2\2\2\5d\3\2\2\2\7j\3\2\2\2\tn\3\2\2\2"+
		"\13v\3\2\2\2\r}\3\2\2\2\17\u0085\3\2\2\2\21\u008f\3\2\2\2\23\u0098\3\2"+
		"\2\2\25\u009f\3\2\2\2\27\u00a8\3\2\2\2\31\u00af\3\2\2\2\33\u00b9\3\2\2"+
		"\2\35\u00bb\3\2\2\2\37\u00bd\3\2\2\2!\u00bf\3\2\2\2#\u00c1\3\2\2\2%\u00c3"+
		"\3\2\2\2\'\u00c5\3\2\2\2)\u00c7\3\2\2\2+\u00c9\3\2\2\2-\u00cb\3\2\2\2"+
		"/\u00cd\3\2\2\2\61\u00cf\3\2\2\2\63\u00d1\3\2\2\2\65\u00d3\3\2\2\2\67"+
		"\u00d5\3\2\2\29\u00d7\3\2\2\2;\u00d9\3\2\2\2=\u00dc\3\2\2\2?\u00de\3\2"+
		"\2\2A\u00e1\3\2\2\2C\u00e3\3\2\2\2E\u00e6\3\2\2\2G\u00e9\3\2\2\2I\u00eb"+
		"\3\2\2\2K\u00ed\3\2\2\2M\u00f0\3\2\2\2O\u00f2\3\2\2\2Q\u00f5\3\2\2\2S"+
		"\u00fb\3\2\2\2U\u00fe\3\2\2\2W\u0102\3\2\2\2Y\u010f\3\2\2\2[\u011d\3\2"+
		"\2\2]\u011f\3\2\2\2_`\7[\2\2`a\7G\2\2ab\7C\2\2bc\7T\2\2c\4\3\2\2\2de\7"+
		"O\2\2ef\7Q\2\2fg\7P\2\2gh\7V\2\2hi\7J\2\2i\6\3\2\2\2jk\7F\2\2kl\7C\2\2"+
		"lm\7[\2\2m\b\3\2\2\2no\7F\2\2op\7C\2\2pq\7[\2\2qr\7Y\2\2rs\7G\2\2st\7"+
		"G\2\2tu\7M\2\2u\n\3\2\2\2vw\7O\2\2wx\7Q\2\2xy\7P\2\2yz\7F\2\2z{\7C\2\2"+
		"{|\7[\2\2|\f\3\2\2\2}~\7V\2\2~\177\7W\2\2\177\u0080\7G\2\2\u0080\u0081"+
		"\7U\2\2\u0081\u0082\7F\2\2\u0082\u0083\7C\2\2\u0083\u0084\7[\2\2\u0084"+
		"\16\3\2\2\2\u0085\u0086\7Y\2\2\u0086\u0087\7G\2\2\u0087\u0088\7F\2\2\u0088"+
		"\u0089\7P\2\2\u0089\u008a\7G\2\2\u008a\u008b\7U\2\2\u008b\u008c\7F\2\2"+
		"\u008c\u008d\7C\2\2\u008d\u008e\7[\2\2\u008e\20\3\2\2\2\u008f\u0090\7"+
		"V\2\2\u0090\u0091\7J\2\2\u0091\u0092\7W\2\2\u0092\u0093\7T\2\2\u0093\u0094"+
		"\7U\2\2\u0094\u0095\7F\2\2\u0095\u0096\7C\2\2\u0096\u0097\7[\2\2\u0097"+
		"\22\3\2\2\2\u0098\u0099\7H\2\2\u0099\u009a\7T\2\2\u009a\u009b\7K\2\2\u009b"+
		"\u009c\7F\2\2\u009c\u009d\7C\2\2\u009d\u009e\7[\2\2\u009e\24\3\2\2\2\u009f"+
		"\u00a0\7U\2\2\u00a0\u00a1\7C\2\2\u00a1\u00a2\7V\2\2\u00a2\u00a3\7W\2\2"+
		"\u00a3\u00a4\7T\2\2\u00a4\u00a5\7F\2\2\u00a5\u00a6\7C\2\2\u00a6\u00a7"+
		"\7[\2\2\u00a7\26\3\2\2\2\u00a8\u00a9\7U\2\2\u00a9\u00aa\7W\2\2\u00aa\u00ab"+
		"\7P\2\2\u00ab\u00ac\7F\2\2\u00ac\u00ad\7C\2\2\u00ad\u00ae\7[\2\2\u00ae"+
		"\30\3\2\2\2\u00af\u00b3\7)\2\2\u00b0\u00b4\n\2\2\2\u00b1\u00b2\7)\2\2"+
		"\u00b2\u00b4\7)\2\2\u00b3\u00b0\3\2\2\2\u00b3\u00b1\3\2\2\2\u00b4\u00b5"+
		"\3\2\2\2\u00b5\u00b3\3\2\2\2\u00b5\u00b6\3\2\2\2\u00b6\u00b7\3\2\2\2\u00b7"+
		"\u00b8\7)\2\2\u00b8\32\3\2\2\2\u00b9\u00ba\7*\2\2\u00ba\34\3\2\2\2\u00bb"+
		"\u00bc\7]\2\2\u00bc\36\3\2\2\2\u00bd\u00be\7+\2\2\u00be \3\2\2\2\u00bf"+
		"\u00c0\7_\2\2\u00c0\"\3\2\2\2\u00c1\u00c2\7<\2\2\u00c2$\3\2\2\2\u00c3"+
		"\u00c4\7=\2\2\u00c4&\3\2\2\2\u00c5\u00c6\7.\2\2\u00c6(\3\2\2\2\u00c7\u00c8"+
		"\7-\2\2\u00c8*\3\2\2\2\u00c9\u00ca\7/\2\2\u00ca,\3\2\2\2\u00cb\u00cc\7"+
		",\2\2\u00cc.\3\2\2\2\u00cd\u00ce\7\60\2\2\u00ce\60\3\2\2\2\u00cf\u00d0"+
		"\7^\2\2\u00d0\62\3\2\2\2\u00d1\u00d2\7#\2\2\u00d2\64\3\2\2\2\u00d3\u00d4"+
		"\7?\2\2\u00d4\66\3\2\2\2\u00d5\u00d6\7\'\2\2\u00d68\3\2\2\2\u00d7\u00d8"+
		"\7`\2\2\u00d8:\3\2\2\2\u00d9\u00da\7#\2\2\u00da\u00db\7?\2\2\u00db<\3"+
		"\2\2\2\u00dc\u00dd\7@\2\2\u00dd>\3\2\2\2\u00de\u00df\7@\2\2\u00df\u00e0"+
		"\7?\2\2\u00e0@\3\2\2\2\u00e1\u00e2\7>\2\2\u00e2B\3\2\2\2\u00e3\u00e4\7"+
		">\2\2\u00e4\u00e5\7?\2\2\u00e5D\3\2\2\2\u00e6\u00e7\7~\2\2\u00e7\u00e8"+
		"\7~\2\2\u00e8F\3\2\2\2\u00e9\u00ea\7~\2\2\u00eaH\3\2\2\2\u00eb\u00ec\7"+
		"(\2\2\u00ecJ\3\2\2\2\u00ed\u00ee\7(\2\2\u00ee\u00ef\7(\2\2\u00efL\3\2"+
		"\2\2\u00f0\u00f1\7^\2\2\u00f1N\3\2\2\2\u00f2\u00f3\7A\2\2\u00f3P\3\2\2"+
		"\2\u00f4\u00f6\t\3\2\2\u00f5\u00f4\3\2\2\2\u00f6\u00f7\3\2\2\2\u00f7\u00f5"+
		"\3\2\2\2\u00f7\u00f8\3\2\2\2\u00f8\u00f9\3\2\2\2\u00f9\u00fa\b)\2\2\u00fa"+
		"R\3\2\2\2\u00fb\u00fc\t\4\2\2\u00fcT\3\2\2\2\u00fd\u00ff\t\5\2\2\u00fe"+
		"\u00fd\3\2\2\2\u00ff\u0100\3\2\2\2\u0100\u00fe\3\2\2\2\u0100\u0101\3\2"+
		"\2\2\u0101V\3\2\2\2\u0102\u0103\7/\2\2\u0103\u0104\7/\2\2\u0104\u0108"+
		"\3\2\2\2\u0105\u0107\n\6\2\2\u0106\u0105\3\2\2\2\u0107\u010a\3\2\2\2\u0108"+
		"\u0106\3\2\2\2\u0108\u0109\3\2\2\2\u0109\u010b\3\2\2\2\u010a\u0108\3\2"+
		"\2\2\u010b\u010c\7\2\2\3\u010c\u010d\3\2\2\2\u010d\u010e\b,\3\2\u010e"+
		"X\3\2\2\2\u010f\u0110\7\61\2\2\u0110\u0111\7,\2\2\u0111\u0115\3\2\2\2"+
		"\u0112\u0114\13\2\2\2\u0113\u0112\3\2\2\2\u0114\u0117\3\2\2\2\u0115\u0116"+
		"\3\2\2\2\u0115\u0113\3\2\2\2\u0116\u0118\3\2\2\2\u0117\u0115\3\2\2\2\u0118"+
		"\u0119\7,\2\2\u0119\u011a\7\61\2\2\u011a\u011b\3\2\2\2\u011b\u011c\b-"+
		"\3\2\u011cZ\3\2\2\2\u011d\u011e\t\7\2\2\u011e\\\3\2\2\2\u011f\u0124\5"+
		"S*\2\u0120\u0123\5S*\2\u0121\u0123\t\b\2\2\u0122\u0120\3\2\2\2\u0122\u0121"+
		"\3\2\2\2\u0123\u0126\3\2\2\2\u0124\u0122\3\2\2\2\u0124\u0125\3\2\2\2\u0125"+
		"^\3\2\2\2\u0126\u0124\3\2\2\2\13\2\u00b3\u00b5\u00f7\u0100\u0108\u0115"+
		"\u0122\u0124\4\b\2\2\2\3\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}