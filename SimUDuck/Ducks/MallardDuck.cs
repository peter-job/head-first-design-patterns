using System;
using System.Collections.Generic;
using System.Text;
using SimUDuck.FlyBehaviours;
using SimUDuck.QuackBehaviours;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck() {
            quackBehaviour = new RealQuack();
            flyBehaviour = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
