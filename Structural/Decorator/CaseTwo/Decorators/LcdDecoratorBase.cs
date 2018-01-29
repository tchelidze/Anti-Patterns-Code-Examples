namespace Decorator.CaseTwo.Decorators
{
    public abstract class LcdDecoratorBase : Lcd
    {
        protected readonly Lcd Lcd;

        protected LcdDecoratorBase(Lcd lcd) => Lcd = lcd;
    }
}