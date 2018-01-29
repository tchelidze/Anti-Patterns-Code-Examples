using Strategy.Solution.Behaviours.Fly;
using Strategy.Solution.Behaviours.Quack;

namespace Strategy.Solution
{
    public class EntryPoint
    {
        public static void Main()
        {
            var rubberDuck = new Duck(new SimpleQuckBehaviour(), new NoFlyBehaviour());
            var wildDuck = new Duck(new SimpleQuckBehaviour(), new JetFlyBehaviour());
        }
    }
}