using System;

namespace HomeTheater
{
    public class TheaterLights
    {
        private readonly string name;

        public TheaterLights(string name)
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

        public void Dim(int level)
        {
            Console.WriteLine("{0} dimming to {1}%", name, level);
        }

        public override string ToString()
        {
            return name;
        }
    }
}