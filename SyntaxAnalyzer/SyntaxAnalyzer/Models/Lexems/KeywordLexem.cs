namespace SyntaxAnalyzer.Models.Lexems
{
    public class ForKeywordLexem : LexemBase
    {
        public override string Name => "For cycle";
        public override string Token => "FOR";
    }

    public class IfKeywordLexem : LexemBase
    {
        public override string Name => "If operator";
        public override string Token => "IF";
    }

    public class ElifKeywordLexem : LexemBase
    {
        public override string Name => "Elif operator";
        public override string Token => "ELIF";
    }

    public class ElseKeywordLexem : LexemBase
    {
        public override string Name => "Else operator";
        public override string Token => "ELSE";
    }
}
