using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.SyntaxItems;
using System.Text.RegularExpressions;

namespace SyntaxAnalyzer.LexicalAnalysis.Scanners
{
    public class OneSymboloperatorScanner : ScannerBase
    {
        private Regex _specification = new Regex(">|<|=|\\+|\\-|\\*|\\/|%|;");
        public override Regex Specification => _specification;

        public override LexemBase MatchHandler(Match match)
        {
            switch(match.Value)
            {
                case ">": return new GreaterThanOperator();
                case "<": return new LessThanOperator();
                case "=": return new AssignOperator();
                case "+": return new PlusOperatorLexem();
                case "-": return new MinusOperatorLexem();
                case "*": return new MultiplyOperatorLexem();
                case "/": return new DivideOperatorLexem();
                case "%": return new ModulateOperatorLexem();
                case ";": return new SemicollonOperator();
            }

            return null;
        }
    }
}
