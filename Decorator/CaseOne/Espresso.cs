namespace Decorator
{
    public class Espresso : Beverage
    {
        public override string Describe() => "I'm simple Espresso";

        public override decimal Cost() => 1.8m;
    }
}