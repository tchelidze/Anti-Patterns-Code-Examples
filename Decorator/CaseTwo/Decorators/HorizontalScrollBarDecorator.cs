using System;

namespace Decorator.CaseTwo.Decorators
{
    public class HorizontalScrollBarDecorator : LcdDecoratorBase
    {
        public HorizontalScrollBarDecorator(Lcd lcd)
            : base(lcd) { }

        public override void Draw()
        {
            Lcd.Draw();
            Console.WriteLine("\tand with scroll bar");
        }
    }
}