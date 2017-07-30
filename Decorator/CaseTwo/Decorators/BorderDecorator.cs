using System;

namespace Decorator.CaseTwo.Decorators
{
    public class BorderDecorator : LcdDecoratorBase
    {
        public BorderDecorator(Lcd lcd) : base(lcd)
        {
        }

        public override void Draw()
        {
            Lcd.Draw();
            Console.WriteLine("\tand with border");
        }
    }
}