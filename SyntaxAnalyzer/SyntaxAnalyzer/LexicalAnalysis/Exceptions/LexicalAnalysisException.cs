using System;

namespace SyntaxAnalyzer.LexicalAnalysis.Exceptions
{
    public class LexicalAnalysisException : Exception
    {
        public int Line { get; private set; }
        public int Column { get; private set; }

        public LexicalAnalysisException(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public override string ToString()
        {
            return $"Lexical error at line {Line}; col {Column}";
        }
    }
}
