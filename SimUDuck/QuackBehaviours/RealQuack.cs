using System;

namespace SimUDuck.QuackBehaviours
{
    public class RealQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
