namespace Composite
{
    public class ValueOperand : IOperand
    {
        readonly decimal _value;

        public ValueOperand(decimal value) => _value = value;

        public decimal GetValue() => _value;
    }
}