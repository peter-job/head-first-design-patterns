using System;

namespace MiniDuckSimulator.QuackBehaviours
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*Silence*");
        }
    }
}
