using System;

namespace MiniDuckSimulator.FlyBehaviours
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
