namespace SyntaxAnalyzer.Models.SyntaxItems
{
    public class NumberLexem : LexemBase
    {
        public override string Name => "Number";
        public override string Token => "Num";
    }
}
