using System;
using System.Collections.Generic;
using System.Text;
using MiniDuckSimulator.FlyBehaviours;
using MiniDuckSimulator.QuackBehaviours;

namespace MiniDuckSimulator
{

    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour { get; set; }
        protected IQuackBehaviour quackBehaviour { get; set; }

        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void SetFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void SetQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
