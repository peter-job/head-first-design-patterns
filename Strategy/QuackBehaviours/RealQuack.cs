using System;

namespace MiniDuckSimulator.QuackBehaviours
{
    public class RealQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
