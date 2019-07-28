using System;
using System.Collections.Generic;
using System.Text;
using SimUDuck.FlyBehaviours;
using SimUDuck.QuackBehaviours;

namespace SimUDuck
{

    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;

        public Duck()
        {
        }

        public abstract void Display();

        public void performFly()
        {
            flyBehaviour.Fly();
        }

        public void performQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
