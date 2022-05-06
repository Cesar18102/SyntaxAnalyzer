using SyntaxAnalyzer.Models;
using SyntaxAnalyzer.Models.Lexems;
using SyntaxAnalyzer.Models.SyntaxItems;

namespace SyntaxAnalyzer.SyntaxAnalysis
{
    public class SyntaxAnalyzer : SyntaxAnalyzerBase
    {
        protected override SyntaxItemBase RootSyntaxItem => ESyntaxItem.Instance;
        protected override TerminalSyntaxItem FinalSyntaxItem => EndTerminal.Instance;

        private SyntaxAnalyzerTable _table;
        protected override SyntaxAnalyzerTable Table => _table;

        public SyntaxAnalyzer()
        {
            _table = new SyntaxAnalyzerTable();

            var idTerminal = new TerminalSyntaxItem(new IdentifierLexem(""));
            var plusTerminal = new TerminalSyntaxItem(new PlusOperatorLexem());
            var multiplyTerminal = new TerminalSyntaxItem(new MultiplyOperatorLexem());
            var openParenthesisTerminal = new TerminalSyntaxItem(new OpenParenthesisLexem());
            var closeParenthesisTerminal = new TerminalSyntaxItem(new CloseParenthesisLexem());

            _table.Add(ESyntaxItem.Instance, idTerminal, TSyntaxItem.Instance, EDashSyntaxItem.Instance);
            _table.Add(ESyntaxItem.Instance, openParenthesisTerminal, TSyntaxItem.Instance, EDashSyntaxItem.Instance);

            _table.Add(EDashSyntaxItem.Instance, plusTerminal, plusTerminal, TSyntaxItem.Instance, EDashSyntaxItem.Instance);
            _table.Add(EDashSyntaxItem.Instance, closeParenthesisTerminal);
            _table.Add(EDashSyntaxItem.Instance, EndTerminal.Instance);

            _table.Add(TSyntaxItem.Instance, idTerminal, FSyntaxItem.Instance, TDashSyntaxItem.Instance);
            _table.Add(TSyntaxItem.Instance, openParenthesisTerminal, FSyntaxItem.Instance, TDashSyntaxItem.Instance);

            _table.Add(TDashSyntaxItem.Instance, plusTerminal);
            _table.Add(TDashSyntaxItem.Instance, multiplyTerminal, multiplyTerminal, FSyntaxItem.Instance, TDashSyntaxItem.Instance);
            _table.Add(TDashSyntaxItem.Instance, closeParenthesisTerminal);
            _table.Add(TDashSyntaxItem.Instance, EndTerminal.Instance);

            _table.Add(FSyntaxItem.Instance, idTerminal, idTerminal);
            _table.Add(FSyntaxItem.Instance, openParenthesisTerminal, openParenthesisTerminal, ESyntaxItem.Instance, openParenthesisTerminal);
        }
    }
}
