namespace SyntaxAnalyzer.Models.SyntaxItems
{
    public class IdentifierLexem : LexemBase
    {
        public IdentifierLexem(string key)
        {
            Key = key;
        }

        public string Key { get; private set; }
        public override string Name => $"Identifier {Key}";

        public override string Token => $"Id";
    }
}
