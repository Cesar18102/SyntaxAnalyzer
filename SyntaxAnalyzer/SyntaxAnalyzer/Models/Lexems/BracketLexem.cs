namespace SyntaxAnalyzer.Models.Lexems
{
    public class OpenParenthesisLexem : LexemBase
    {
        public override string Name => "Open parenthesis";
        public override string Token => "OPTS";
    }

    public class CloseParenthesisLexem : LexemBase
    {
        public override string Name => "Close parenthesis";
        public override string Token => "CPTS";
    }

    public class OpenSquareBracketLexem : LexemBase
    {
        public override string Name => "Open square bracket";
        public override string Token => "OSQB";
    }

    public class CloseSquareBracketLexem : LexemBase
    {
        public override string Name => "Close square bracket";
        public override string Token => "CSQB";
    }

    public class OpenCurveBracketLexem : LexemBase
    {
        public override string Name => "Open curve bracket";
        public override string Token => "OCRB";
    }

    public class CloseCurveBracketLexem : LexemBase
    {
        public override string Name => "Close curve bracket";
        public override string Token => "CCRB";
    }
}
