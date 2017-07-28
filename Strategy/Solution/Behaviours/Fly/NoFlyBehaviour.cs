using System;

namespace Strategy.Solution.Behaviours.Fly
{
    public class NoFlyBehaviour : IFlyBehaviour
    {
        public void Fly() => Console.WriteLine("Are you kidding ?");
    }
}