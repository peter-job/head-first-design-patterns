using System;

namespace TurkeyAdapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance!");
        }
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
