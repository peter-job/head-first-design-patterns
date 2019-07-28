using System;
using SimUDuck.FlyBehaviours;

namespace SimUDuck
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
