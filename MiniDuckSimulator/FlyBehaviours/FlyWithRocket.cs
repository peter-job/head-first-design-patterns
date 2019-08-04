using System;

namespace MiniDuckSimulator.FlyBehaviours
{
    public class FlyWithRocket : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
