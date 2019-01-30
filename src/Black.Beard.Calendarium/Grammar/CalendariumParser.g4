/**
 * workflow engine Parser
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

parser grammar CalendariumParser;

options { 
    // memoize=True;
    tokenVocab=CalendariumLexer; 
    }

script :
      expression
    | INTEROGATION expression_bool COLON expression
    ;

expression_bool
    :  dayweek (OR dayweek)?
    |  LEFT_PAREN expression_bool RIGHT_PAREN
    ;

expression :
      rule expression?
    | LEFT_PAREN expression RIGHT_PAREN expression?
    // | NOT expression expression?
    | operation expression
    ;

operation : 
      PLUS | MINUS 
    // | TIME | DIVID
    // | MODULO
    // | EQUAL | NOT_EQUAL
    // | GREATER | GREATER_OR_EQUAL | LESS | LESS_OR_EQUAL
    // | AND | ANDALSO | OR | XOR
    // | (PLUS PLUS)
    | (GREATER GREATER)
    | (LESS LESS)
    ;

rule : 
      mask
    | LEFT_BRACKET identifier RIGHT_BRACKET
    | TIME? dayweek
    | NUMBER
    ;

mask : 
    month=NUMBER MINUS day=NUMBER
    ;

dayweek : MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY | SATURDAY | SUNDAY;

identifier : REGULAR_ID;

