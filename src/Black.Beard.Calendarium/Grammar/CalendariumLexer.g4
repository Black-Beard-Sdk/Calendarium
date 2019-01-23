/**
 * Oracle(c) PL/SQL 11g Parser
 *
 * Copyright (c) 2009-2011 Black Beard - Gael beard <gaelgael5@gmail.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

lexer grammar CalendariumLexer;

YEAR :      'YEAR';
MONTH :     'MONTH';
DAY :       'DAY';
DAYWEEK :   'DAYWEEK';

MONDAY :    'MONDAY';
TUESDAY	 :  'TUESDAY';
WEDNESDAY : 'WEDNESDAY';
THURSDAY :  'THURSDAY';
FRIDAY :    'FRIDAY';
SATURDAY :  'SATURDAY';
SUNDAY :    'SUNDAY';


// and a superfluous subtoken typecasting of the "QUOTE"
CHAR_STRING:  '\'' (~('\'' | '\r' | '\n') | '\'\'')+ '\'';

// SQL_SPECIAL_CHAR was split into single rules
LEFT_PAREN :            '(';
LEFT_BRACKET :          '[';
RIGHT_PAREN :           ')';
RIGHT_BRACKET :         ']';
COLON :                 ':';
SEMICOLON :             ';';
COMMA :                 ',';
PLUS :                  '+';
MINUS :                 '-';
TIME :                  '*';
DOT :                   '.';
DIVID :                 '\\';
NOT :                   '!';
EQUAL :                 '=';
MODULO :                '%';
POWER :                 '^';
NOT_EQUAL :             '!=';
GREATER :               '>';
GREATER_OR_EQUAL :      '>=';
LESS :                  '<';
LESS_OR_EQUAL :         '<=';
XOR :                   '||';
OR :                    '|';
AND :                   '&';
ANDALSO :               '&&';
SLASH :                 '\\';

SPACES: [ \t\r\n]+ -> skip;
    
// Rule #504 <SIMPLE_LETTER> - simple_latin _letter was generalised into SIMPLE_LETTER
//  Unicode is yet to be implemented - see NSF0
fragment
SIMPLE_LETTER
    : [A-Za-z]
    ;

NUMBER
    : [0-9]+
    ;

// Rule #097 <COMMENT>
SINGLE_LINE_COMMENT: '--' ~('\r' | '\n')* EOF               -> channel(HIDDEN);
MULTI_LINE_COMMENT:  '/*' .*? '*/'                          -> channel(HIDDEN);
    
fragment
SPACE: [ \t];

REGULAR_ID: SIMPLE_LETTER (SIMPLE_LETTER | '$' | '_' | '#' | [0-9])*;
