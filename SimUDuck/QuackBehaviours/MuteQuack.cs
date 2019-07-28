using System;

namespace SimUDuck.QuackBehaviours
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*Silence*");
        }
    }
}
