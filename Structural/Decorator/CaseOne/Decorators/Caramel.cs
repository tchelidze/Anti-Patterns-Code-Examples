namespace Decorator.CaseOne.Decorators
{
    public class Caramel : BeverageDecoratorBase
    {
        public Caramel(Beverage beverage) : base(beverage)
        {
        }

        public override string Describe() => $"{Beverage.Describe()} with Caramel";

        public override decimal Cost() => Beverage.Cost() + 0.4m;
    }
}