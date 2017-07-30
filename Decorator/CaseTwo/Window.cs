using System;

namespace Decorator.CaseTwo
{
    public class Window : Lcd
    {
        public override void Draw()
            => Console.WriteLine($"Drawing Window of {Width} width and {Height} height");
    }
}