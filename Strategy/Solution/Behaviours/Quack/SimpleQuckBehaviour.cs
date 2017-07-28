using System;

namespace Strategy.Solution.Behaviours.Quack
{
    public class SimpleQuckBehaviour : IQuackBehaviour
    {
        public void Quack() => Console.WriteLine("Quack Quack simply");
    }
}