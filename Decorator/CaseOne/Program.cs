using Decorator.CaseOne.Decorators;
using System;

namespace Decorator.CaseOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var decafWithCaramel = new Caramel(new Decaf());
            Console.WriteLine(decafWithCaramel.Describe());

            var espressoWithSoyAndCaramel = new Caramel(new Soy(new Decaf()));
            Console.WriteLine(espressoWithSoyAndCaramel.Describe());
        }
    }
}