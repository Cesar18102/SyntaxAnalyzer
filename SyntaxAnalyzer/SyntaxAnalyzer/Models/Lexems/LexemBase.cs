namespace SyntaxAnalyzer.Models
{
    public abstract class LexemBase
    {
        public abstract string Name { get; }
        public abstract string Token { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
