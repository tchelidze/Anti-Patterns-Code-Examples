namespace Decorator.CaseOne
{
    public class Decaf : Beverage
    {
        public override string Describe() => "I'm simple Decaf dude";

        public override decimal Cost() => 1.2m;
    }
}