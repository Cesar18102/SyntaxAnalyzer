using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.SyntaxItems;
using System.Text.RegularExpressions;

namespace SyntaxAnalyzer.LexicalAnalysis.Scanners
{
    public class IdentifierScanner : ScannerBase
    {
        private Regex _specification = new Regex("[A-Za-z][A-Za-z0-9]*");
        public override Regex Specification => _specification;

        public override LexemBase MatchHandler(Match match)
        {
            return new IdentifierLexem(match.Value);
        }
    }
}
