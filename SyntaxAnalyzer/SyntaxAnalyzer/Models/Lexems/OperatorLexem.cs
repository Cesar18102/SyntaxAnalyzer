namespace SyntaxAnalyzer.Models.SyntaxItems
{
    public class PlusOperatorLexem : LexemBase
    {
        public override string Name => "Plus";
        public override string Token => "AddOp";
    }

    public class MinusOperatorLexem : LexemBase
    {
        public override string Name => "Minus";
        public override string Token => "SubOp";
    }

    public class MultiplyOperatorLexem : LexemBase
    {
        public override string Name => "Multiply";
        public override string Token => "MulOp";
    }

    public class DivideOperatorLexem : LexemBase
    {
        public override string Name => "Divide";
        public override string Token => "DivOp";
    }

    public class ModulateOperatorLexem : LexemBase
    {
        public override string Name => "Modulate";
        public override string Token => "ModOp";
    }

    public class GreaterThanOperator : LexemBase
    {
        public override string Name => "Greater";
        public override string Token => "GT";
    }

    public class GreaterOrEqualOperator : LexemBase
    {
        public override string Name => "Greater or equal";
        public override string Token => "GE";
    }

    public class LessThanOperator : LexemBase
    {
        public override string Name => "Less";
        public override string Token => "LT";
    }

    public class LessOrEqualOperator : LexemBase
    {
        public override string Name => "Less or equal";
        public override string Token => "LE";
    }

    public class EqualOperator : LexemBase
    {
        public override string Name => "Equal";
        public override string Token => "EQ";
    }

    public class AssignOperator : LexemBase
    {
        public override string Name => "Assign";
        public override string Token => "ASGN";
    }

    public class SemicollonOperator : LexemBase
    {
        public override string Name => "Semicollon";
        public override string Token => "SCLN";
    }
}
