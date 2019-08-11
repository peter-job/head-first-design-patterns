using System;

namespace MiniDuckSimulator.FlyBehaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
