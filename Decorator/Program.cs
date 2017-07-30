using Decorator.CaseOne;
using Decorator.CaseOne.Decorators;
using Decorator.CaseTwo;
using Decorator.CaseTwo.Decorators;
using System;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Case One

            var decafWithCaramel = new Caramel(new Decaf());
            Console.WriteLine(decafWithCaramel.Describe());

            var espressoWithSoyAndCaramel = new Caramel(new Soy(new Decaf()));
            Console.WriteLine(espressoWithSoyAndCaramel.Describe());

            #endregion

            #region Case Two

            var windowWithBorderAndVerticalScrollBar =
                new VerticalScrollBarDecorator(new BorderDecorator(new Window { Width = 12, Height = 32 }));
            windowWithBorderAndVerticalScrollBar.Draw();

            var windowWithVerticalAndHorizontalBar =
                new HorizontalScrollBarDecorator(
                    new VerticalScrollBarDecorator(new Window { Width = 11, Height = 22 }));
            windowWithVerticalAndHorizontalBar.Draw();

            #endregion
        }
    }
}