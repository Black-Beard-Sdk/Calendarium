// Generated from d:\Src\Calendarium\src\Black.Beard.Calendarium\Grammar\CalendariumParser.g4 by ANTLR 4.7.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class CalendariumParser extends Parser {
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
	public static final int
		RULE_script = 0, RULE_expression_bool = 1, RULE_expression = 2, RULE_operation = 3, 
		RULE_rule = 4, RULE_mask = 5, RULE_dayweek = 6, RULE_identifier = 7;
	public static final String[] ruleNames = {
		"script", "expression_bool", "expression", "operation", "rule", "mask", 
		"dayweek", "identifier"
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

	@Override
	public String getGrammarFileName() { return "CalendariumParser.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public CalendariumParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class ScriptContext extends ParserRuleContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode INTEROGATION() { return getToken(CalendariumParser.INTEROGATION, 0); }
		public Expression_boolContext expression_bool() {
			return getRuleContext(Expression_boolContext.class,0);
		}
		public TerminalNode COLON() { return getToken(CalendariumParser.COLON, 0); }
		public ScriptContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_script; }
	}

	public final ScriptContext script() throws RecognitionException {
		ScriptContext _localctx = new ScriptContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_script);
		try {
			setState(22);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case MONDAY:
			case TUESDAY:
			case WEDNESDAY:
			case THURSDAY:
			case FRIDAY:
			case SATURDAY:
			case SUNDAY:
			case LEFT_PAREN:
			case LEFT_BRACKET:
			case PLUS:
			case MINUS:
			case TIME:
			case GREATER:
			case LESS:
			case NUMBER:
				enterOuterAlt(_localctx, 1);
				{
				setState(16);
				expression();
				}
				break;
			case INTEROGATION:
				enterOuterAlt(_localctx, 2);
				{
				setState(17);
				match(INTEROGATION);
				setState(18);
				expression_bool();
				setState(19);
				match(COLON);
				setState(20);
				expression();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Expression_boolContext extends ParserRuleContext {
		public List<DayweekContext> dayweek() {
			return getRuleContexts(DayweekContext.class);
		}
		public DayweekContext dayweek(int i) {
			return getRuleContext(DayweekContext.class,i);
		}
		public TerminalNode OR() { return getToken(CalendariumParser.OR, 0); }
		public TerminalNode LEFT_PAREN() { return getToken(CalendariumParser.LEFT_PAREN, 0); }
		public Expression_boolContext expression_bool() {
			return getRuleContext(Expression_boolContext.class,0);
		}
		public TerminalNode RIGHT_PAREN() { return getToken(CalendariumParser.RIGHT_PAREN, 0); }
		public Expression_boolContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression_bool; }
	}

	public final Expression_boolContext expression_bool() throws RecognitionException {
		Expression_boolContext _localctx = new Expression_boolContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_expression_bool);
		int _la;
		try {
			setState(33);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case MONDAY:
			case TUESDAY:
			case WEDNESDAY:
			case THURSDAY:
			case FRIDAY:
			case SATURDAY:
			case SUNDAY:
				enterOuterAlt(_localctx, 1);
				{
				setState(24);
				dayweek();
				setState(27);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==OR) {
					{
					setState(25);
					match(OR);
					setState(26);
					dayweek();
					}
				}

				}
				break;
			case LEFT_PAREN:
				enterOuterAlt(_localctx, 2);
				{
				setState(29);
				match(LEFT_PAREN);
				setState(30);
				expression_bool();
				setState(31);
				match(RIGHT_PAREN);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExpressionContext extends ParserRuleContext {
		public RuleContext rule() {
			return getRuleContext(RuleContext.class,0);
		}
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode LEFT_PAREN() { return getToken(CalendariumParser.LEFT_PAREN, 0); }
		public TerminalNode RIGHT_PAREN() { return getToken(CalendariumParser.RIGHT_PAREN, 0); }
		public OperationContext operation() {
			return getRuleContext(OperationContext.class,0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	}

	public final ExpressionContext expression() throws RecognitionException {
		ExpressionContext _localctx = new ExpressionContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_expression);
		int _la;
		try {
			setState(48);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case MONDAY:
			case TUESDAY:
			case WEDNESDAY:
			case THURSDAY:
			case FRIDAY:
			case SATURDAY:
			case SUNDAY:
			case LEFT_BRACKET:
			case TIME:
			case NUMBER:
				enterOuterAlt(_localctx, 1);
				{
				setState(35);
				rule();
				setState(37);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MONDAY) | (1L << TUESDAY) | (1L << WEDNESDAY) | (1L << THURSDAY) | (1L << FRIDAY) | (1L << SATURDAY) | (1L << SUNDAY) | (1L << LEFT_PAREN) | (1L << LEFT_BRACKET) | (1L << PLUS) | (1L << MINUS) | (1L << TIME) | (1L << GREATER) | (1L << LESS) | (1L << NUMBER))) != 0)) {
					{
					setState(36);
					expression();
					}
				}

				}
				break;
			case LEFT_PAREN:
				enterOuterAlt(_localctx, 2);
				{
				setState(39);
				match(LEFT_PAREN);
				setState(40);
				expression();
				setState(41);
				match(RIGHT_PAREN);
				setState(43);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MONDAY) | (1L << TUESDAY) | (1L << WEDNESDAY) | (1L << THURSDAY) | (1L << FRIDAY) | (1L << SATURDAY) | (1L << SUNDAY) | (1L << LEFT_PAREN) | (1L << LEFT_BRACKET) | (1L << PLUS) | (1L << MINUS) | (1L << TIME) | (1L << GREATER) | (1L << LESS) | (1L << NUMBER))) != 0)) {
					{
					setState(42);
					expression();
					}
				}

				}
				break;
			case PLUS:
			case MINUS:
			case GREATER:
			case LESS:
				enterOuterAlt(_localctx, 3);
				{
				setState(45);
				operation();
				setState(46);
				expression();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class OperationContext extends ParserRuleContext {
		public TerminalNode PLUS() { return getToken(CalendariumParser.PLUS, 0); }
		public TerminalNode MINUS() { return getToken(CalendariumParser.MINUS, 0); }
		public List<TerminalNode> GREATER() { return getTokens(CalendariumParser.GREATER); }
		public TerminalNode GREATER(int i) {
			return getToken(CalendariumParser.GREATER, i);
		}
		public List<TerminalNode> LESS() { return getTokens(CalendariumParser.LESS); }
		public TerminalNode LESS(int i) {
			return getToken(CalendariumParser.LESS, i);
		}
		public OperationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_operation; }
	}

	public final OperationContext operation() throws RecognitionException {
		OperationContext _localctx = new OperationContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_operation);
		try {
			setState(56);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case PLUS:
				enterOuterAlt(_localctx, 1);
				{
				setState(50);
				match(PLUS);
				}
				break;
			case MINUS:
				enterOuterAlt(_localctx, 2);
				{
				setState(51);
				match(MINUS);
				}
				break;
			case GREATER:
				enterOuterAlt(_localctx, 3);
				{
				{
				setState(52);
				match(GREATER);
				setState(53);
				match(GREATER);
				}
				}
				break;
			case LESS:
				enterOuterAlt(_localctx, 4);
				{
				{
				setState(54);
				match(LESS);
				setState(55);
				match(LESS);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class RuleContext extends ParserRuleContext {
		public MaskContext mask() {
			return getRuleContext(MaskContext.class,0);
		}
		public TerminalNode LEFT_BRACKET() { return getToken(CalendariumParser.LEFT_BRACKET, 0); }
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode RIGHT_BRACKET() { return getToken(CalendariumParser.RIGHT_BRACKET, 0); }
		public DayweekContext dayweek() {
			return getRuleContext(DayweekContext.class,0);
		}
		public TerminalNode TIME() { return getToken(CalendariumParser.TIME, 0); }
		public TerminalNode NUMBER() { return getToken(CalendariumParser.NUMBER, 0); }
		public RuleContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_rule; }
	}

	public final RuleContext rule() throws RecognitionException {
		RuleContext _localctx = new RuleContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_rule);
		int _la;
		try {
			setState(68);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(58);
				mask();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(59);
				match(LEFT_BRACKET);
				setState(60);
				identifier();
				setState(61);
				match(RIGHT_BRACKET);
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(64);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==TIME) {
					{
					setState(63);
					match(TIME);
					}
				}

				setState(66);
				dayweek();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(67);
				match(NUMBER);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MaskContext extends ParserRuleContext {
		public Token month;
		public Token day;
		public TerminalNode MINUS() { return getToken(CalendariumParser.MINUS, 0); }
		public List<TerminalNode> NUMBER() { return getTokens(CalendariumParser.NUMBER); }
		public TerminalNode NUMBER(int i) {
			return getToken(CalendariumParser.NUMBER, i);
		}
		public MaskContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_mask; }
	}

	public final MaskContext mask() throws RecognitionException {
		MaskContext _localctx = new MaskContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_mask);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(70);
			((MaskContext)_localctx).month = match(NUMBER);
			setState(71);
			match(MINUS);
			setState(72);
			((MaskContext)_localctx).day = match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DayweekContext extends ParserRuleContext {
		public TerminalNode MONDAY() { return getToken(CalendariumParser.MONDAY, 0); }
		public TerminalNode TUESDAY() { return getToken(CalendariumParser.TUESDAY, 0); }
		public TerminalNode WEDNESDAY() { return getToken(CalendariumParser.WEDNESDAY, 0); }
		public TerminalNode THURSDAY() { return getToken(CalendariumParser.THURSDAY, 0); }
		public TerminalNode FRIDAY() { return getToken(CalendariumParser.FRIDAY, 0); }
		public TerminalNode SATURDAY() { return getToken(CalendariumParser.SATURDAY, 0); }
		public TerminalNode SUNDAY() { return getToken(CalendariumParser.SUNDAY, 0); }
		public DayweekContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_dayweek; }
	}

	public final DayweekContext dayweek() throws RecognitionException {
		DayweekContext _localctx = new DayweekContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_dayweek);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(74);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MONDAY) | (1L << TUESDAY) | (1L << WEDNESDAY) | (1L << THURSDAY) | (1L << FRIDAY) | (1L << SATURDAY) | (1L << SUNDAY))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode REGULAR_ID() { return getToken(CalendariumParser.REGULAR_ID, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(76);
			match(REGULAR_ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3.Q\4\2\t\2\4\3\t\3"+
		"\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\3\2\3\2\3\2\3\2\3\2\3"+
		"\2\5\2\31\n\2\3\3\3\3\3\3\5\3\36\n\3\3\3\3\3\3\3\3\3\5\3$\n\3\3\4\3\4"+
		"\5\4(\n\4\3\4\3\4\3\4\3\4\5\4.\n\4\3\4\3\4\3\4\5\4\63\n\4\3\5\3\5\3\5"+
		"\3\5\3\5\3\5\5\5;\n\5\3\6\3\6\3\6\3\6\3\6\3\6\5\6C\n\6\3\6\3\6\5\6G\n"+
		"\6\3\7\3\7\3\7\3\7\3\b\3\b\3\t\3\t\3\t\2\2\n\2\4\6\b\n\f\16\20\2\3\3\2"+
		"\7\r\2V\2\30\3\2\2\2\4#\3\2\2\2\6\62\3\2\2\2\b:\3\2\2\2\nF\3\2\2\2\fH"+
		"\3\2\2\2\16L\3\2\2\2\20N\3\2\2\2\22\31\5\6\4\2\23\24\7)\2\2\24\25\5\4"+
		"\3\2\25\26\7\23\2\2\26\27\5\6\4\2\27\31\3\2\2\2\30\22\3\2\2\2\30\23\3"+
		"\2\2\2\31\3\3\2\2\2\32\35\5\16\b\2\33\34\7%\2\2\34\36\5\16\b\2\35\33\3"+
		"\2\2\2\35\36\3\2\2\2\36$\3\2\2\2\37 \7\17\2\2 !\5\4\3\2!\"\7\21\2\2\""+
		"$\3\2\2\2#\32\3\2\2\2#\37\3\2\2\2$\5\3\2\2\2%\'\5\n\6\2&(\5\6\4\2\'&\3"+
		"\2\2\2\'(\3\2\2\2(\63\3\2\2\2)*\7\17\2\2*+\5\6\4\2+-\7\21\2\2,.\5\6\4"+
		"\2-,\3\2\2\2-.\3\2\2\2.\63\3\2\2\2/\60\5\b\5\2\60\61\5\6\4\2\61\63\3\2"+
		"\2\2\62%\3\2\2\2\62)\3\2\2\2\62/\3\2\2\2\63\7\3\2\2\2\64;\7\26\2\2\65"+
		";\7\27\2\2\66\67\7 \2\2\67;\7 \2\289\7\"\2\29;\7\"\2\2:\64\3\2\2\2:\65"+
		"\3\2\2\2:\66\3\2\2\2:8\3\2\2\2;\t\3\2\2\2<G\5\f\7\2=>\7\20\2\2>?\5\20"+
		"\t\2?@\7\22\2\2@G\3\2\2\2AC\7\30\2\2BA\3\2\2\2BC\3\2\2\2CD\3\2\2\2DG\5"+
		"\16\b\2EG\7+\2\2F<\3\2\2\2F=\3\2\2\2FB\3\2\2\2FE\3\2\2\2G\13\3\2\2\2H"+
		"I\7+\2\2IJ\7\27\2\2JK\7+\2\2K\r\3\2\2\2LM\t\2\2\2M\17\3\2\2\2NO\7.\2\2"+
		"O\21\3\2\2\2\13\30\35#\'-\62:BF";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}