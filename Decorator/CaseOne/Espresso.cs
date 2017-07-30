namespace Decorator.CaseOne
{
    public class Espresso : Beverage
    {
        public override string Describe() => "I'm simple Window";

        public override decimal Cost() => 1.8m;
    }
}