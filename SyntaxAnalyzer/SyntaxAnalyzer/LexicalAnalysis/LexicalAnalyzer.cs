using SyntaxAnalyzer.LexicalAnalysis.Scanners;
using System.Collections.Generic;

namespace SyntaxAnalyzer.LexicalAnalysis
{
    public class LexicalAnalyzer : LexicalAnalyzerBase
    {
        private IList<ScannerBase> _scanners = new List<ScannerBase>();
        protected override IList<ScannerBase> Scanners => _scanners;

        public LexicalAnalyzer()
        {
            _scanners.Add(new KeywordScanner());
            _scanners.Add(new IdentifierScanner());
            _scanners.Add(new NumberScanner());
            _scanners.Add(new TwoSymbolOperatorScanner());
            _scanners.Add(new OneSymboloperatorScanner());
            _scanners.Add(new BracketsScanner());
        }
    }
}
