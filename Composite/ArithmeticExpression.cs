using System;

namespace Composite
{
    public class ArithmeticExpression
    {
        readonly IOperand _left;
        readonly IOperand _right;
        readonly Operator _operator;

        public ArithmeticExpression(
            IOperand left,
            IOperand right,
            Operator @operator)
        {
            _left = left;
            _right = right;
            _operator = @operator;
        }

        public decimal GetValue()
        {
            var left = _left.GetValue();
            var right = _right.GetValue();
            switch (_operator)
            {
                case Operator.Add:
                    return left + right;
                case Operator.Minus:
                    return left - right;
                case Operator.Divide:
                    return left / right;
                case Operator.Multiply:
                    return left * right;
                default:
                    throw new InvalidOperationException($"Operator {_operator} is not supported");
            }
        }
    }

    public enum Operator
    {
        Add,
        Minus,
        Divide,
        Multiply
    }
}