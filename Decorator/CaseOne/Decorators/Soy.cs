namespace Decorator.CaseOne.Decorators
{
    public class Soy : BeverageDecoratorBase
    {
        public Soy(Beverage beverage) : base(beverage)
        { }

        public override string Describe()
            => $"{Beverage.Describe()} with Soy";

        public override decimal Cost() => Beverage.Cost() + 0.2m;
    }
}