using System;
using MiniDuckSimulator.FlyBehaviours;

namespace MiniDuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehaviour(new FlyWithRocket());
            model.PerformFly();
        }
    }
}
