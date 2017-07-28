using System;

namespace Strategy.Problem
{
    public abstract class Duck
    {
        public bool Name { get; set; }

        public void Describe() => Console.WriteLine($"Hi i'm {Name}");

        public abstract void Fly();
    }
}