using System;

namespace MiniDuckSimulator.QuackBehaviours
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
