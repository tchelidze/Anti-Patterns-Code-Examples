using System;

namespace Strategy.Problem
{
    public class CityDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("City Duck is flying");
        }
    }
}