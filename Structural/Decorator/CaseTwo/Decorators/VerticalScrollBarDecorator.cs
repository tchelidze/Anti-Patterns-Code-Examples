using System;

namespace Decorator.CaseTwo.Decorators
{
    public class VerticalScrollBarDecorator : LcdDecoratorBase
    {
        public VerticalScrollBarDecorator(Lcd lcd)
            : base(lcd) { }

        public override void Draw()
        {
            Lcd.Draw();
            Console.WriteLine("\tand with vertical scrollbar");
        }
    }
}