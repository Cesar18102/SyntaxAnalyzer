using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.SyntaxItems;
using System.Text.RegularExpressions;

namespace SyntaxAnalyzer.LexicalAnalysis.Scanners
{
    public class NumberScanner : ScannerBase
    {
        private Regex _specification = new Regex("\\d+");
        public override Regex Specification => _specification;

        public override LexemBase MatchHandler(Match match)
        {
            return new NumberLexem();
        }
    }
}
