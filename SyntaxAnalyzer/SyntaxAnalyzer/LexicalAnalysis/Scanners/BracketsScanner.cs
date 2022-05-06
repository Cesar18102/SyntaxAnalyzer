using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.Lexems;
using System.Text.RegularExpressions;

namespace SyntaxAnalyzer.LexicalAnalysis.Scanners
{
    public class BracketsScanner : ScannerBase
    {
        private Regex _specification = new Regex("\\(|\\)|\\[|\\]|\\{|\\}");
        public override Regex Specification => _specification;

        public override LexemBase MatchHandler(Match match)
        {
            switch(match.Value)
            {
                case "(": return new OpenParenthesisLexem();
                case ")": return new CloseParenthesisLexem();
                case "[": return new OpenSquareBracketLexem();
                case "]": return new CloseSquareBracketLexem();
                case "{": return new OpenCurveBracketLexem();
                case "}": return new CloseCurveBracketLexem();
            }

            return null;
        }
    }
}
