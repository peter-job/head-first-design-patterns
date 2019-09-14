using System;

namespace HomeTheater
{
    public class PopcornPopper
    {
        private readonly string name;

        public PopcornPopper(string name)
        {
            this.name = name;
        }

        public void On()
        {
            Console.WriteLine("{0} on", name);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", name);
        }

        public void Pop()
        {
            Console.WriteLine("{0} popping popcorn!", name);
        }

        public override string ToString()
        {
            return name;
        }
    }
}