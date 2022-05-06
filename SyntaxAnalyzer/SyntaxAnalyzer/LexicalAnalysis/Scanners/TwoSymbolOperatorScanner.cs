using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.SyntaxItems;
using System.Text.RegularExpressions;

namespace SyntaxAnalyzer.LexicalAnalysis.Scanners
{
    public class TwoSymbolOperatorScanner : ScannerBase
    {
        private Regex _specification = new Regex("(>=)|(<=)|(==)");
        public override Regex Specification => _specification;

        public override LexemBase MatchHandler(Match match)
        {
            switch (match.Value)
            {
                case ">=": return new GreaterOrEqualOperator();
                case "<=": return new LessOrEqualOperator();
                case "==": return new EqualOperator();
            }

            return null;
        }
    }
}
