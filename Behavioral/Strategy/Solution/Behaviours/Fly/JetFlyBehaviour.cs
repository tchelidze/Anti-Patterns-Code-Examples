using System;

namespace Strategy.Solution.Behaviours.Fly
{
    public class JetFlyBehaviour : IFlyBehaviour
    {
        public void Fly() => Console.WriteLine("Flying jetly");
    }
}