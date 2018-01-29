namespace Decorator.CaseOne.Decorators
{
    public abstract class BeverageDecoratorBase : Beverage
    {
        protected readonly Beverage Beverage;

        protected BeverageDecoratorBase(Beverage beverage) => Beverage = beverage;
    }
}