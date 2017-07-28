using Strategy.Solution.Behaviours.Fly;

namespace Strategy.Solution
{
    public class Duck
    {
        readonly IQuackBehaviour _quackBehaviour;
        readonly IFlyBehaviour _flyBehaviour;

        public Duck(
            IQuackBehaviour quackBehaviour,
            IFlyBehaviour flyBehaviour)
        {
            _quackBehaviour = quackBehaviour;
            _flyBehaviour = flyBehaviour;
        }

        public void Fly() => _flyBehaviour.Fly();

        public void Quack() => _quackBehaviour.Quack();
    }
}