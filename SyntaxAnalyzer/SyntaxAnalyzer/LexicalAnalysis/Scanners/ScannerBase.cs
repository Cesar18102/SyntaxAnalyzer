using SyntaxAnalyzer.Models;
using System.Text.RegularExpressions;

namespace SyntaxAnalyzer.LexicalAnalysis.Scanners
{
    public abstract class ScannerBase
    {
        public abstract Regex Specification { get; }
        public abstract LexemBase MatchHandler(Match match);
    }
}
