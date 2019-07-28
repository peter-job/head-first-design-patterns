using System;
using SimUDuck.FlyBehaviours;
using SimUDuck.QuackBehaviours;

namespace SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new RealQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
