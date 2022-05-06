using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.Lexems;
using System.Text.RegularExpressions;

namespace SyntaxAnalyzer.LexicalAnalysis.Scanners
{
    public class KeywordScanner : ScannerBase
    {
        private Regex _specification = new Regex("(for)|(if)|(elif)|(else)");
        public override Regex Specification => _specification;

        public override LexemBase MatchHandler(Match match)
        {
            switch(match.Value)
            {
                case "for": return new ForKeywordLexem();
                case "if": return new IfKeywordLexem();
                case "elif": return new ElifKeywordLexem();
                case "else": return new ElseKeywordLexem();
            }

            return null;
        }
    }
}
