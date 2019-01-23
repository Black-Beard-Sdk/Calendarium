# antlr-4.7-complete.jar must be preset 
# http://www.antlr.org/download/antlr-4.7-complete.jar

java.exe -jar antlr-4.7-complete.jar -Dlanguage=CSharp CalendariumLexer.g4 -visitor -no-listener -package Bb.Calendaruim.Parser
java.exe -jar antlr-4.7-complete.jar -Dlanguage=CSharp CalendariumParser.g4 -visitor -no-listener -package Bb.Calendaruim.Parser