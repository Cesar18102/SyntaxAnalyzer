namespace SyntaxAnalyzer.Models.SyntaxItems
{
    public abstract class SyntaxItemBase
    {
        public abstract string Name { get; }
        public abstract bool IsTerminal { get; }
        public abstract LexemBase Lexem { get; }
        public bool IsEnd { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class TerminalSyntaxItem : SyntaxItemBase
    {
        private LexemBase _lexem;

        public override LexemBase Lexem => _lexem;
        public override bool IsTerminal => true;
        public override string Name => $"{Lexem?.Name}(Terminal)";
        
        public TerminalSyntaxItem(LexemBase lexem)
        {
            _lexem = lexem;
        }
    }

    public class EndTerminal : TerminalSyntaxItem
    {
        public static EndTerminal Instance = new EndTerminal(null);

        private EndTerminal(LexemBase lexem) : base(lexem)
        {
            IsEnd = true;
        }
    }

    public abstract class NonTerminalSyntaxItem : SyntaxItemBase
    {
        public override bool IsTerminal => false;
        public override LexemBase Lexem => null;
    }

    public class ESyntaxItem : NonTerminalSyntaxItem
    {
        public static ESyntaxItem Instance = new ESyntaxItem();
        private ESyntaxItem() { }

        public override string Name => "E";
    }

    public class EDashSyntaxItem : NonTerminalSyntaxItem
    {
        public static EDashSyntaxItem Instance = new EDashSyntaxItem();
        private EDashSyntaxItem() { }

        public override string Name => "E'";
    }

    public class TSyntaxItem : NonTerminalSyntaxItem
    {
        public static TSyntaxItem Instance = new TSyntaxItem();
        private TSyntaxItem() { }

        public override string Name => "T";
    }

    public class TDashSyntaxItem : NonTerminalSyntaxItem
    {
        public static TDashSyntaxItem Instance = new TDashSyntaxItem();
        private TDashSyntaxItem() { }

        public override string Name => "T'";
    }

    public class FSyntaxItem : NonTerminalSyntaxItem
    {
        public static FSyntaxItem Instance = new FSyntaxItem();
        private FSyntaxItem() { }

        public override string Name => "F";
    }
}
