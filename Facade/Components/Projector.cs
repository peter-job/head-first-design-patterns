using System;

namespace HomeTheater
{
    public class Projector
    {
        private readonly string name;
        private readonly DvdPlayer dvdPlayer;

        public Projector(string name, DvdPlayer dvdPlayer)
        {
            this.name = name;
            this.dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("{0} on", name);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", name);
        }

        public void WideScreenMode()
        {
            Console.WriteLine("{0} in widescreen mode (16x9 aspect ratio)", name);
        }

        public void TvMode()
        {
            Console.WriteLine("{0} in tv mode (4x3 aspect ratio)", name);
        }

        public override string ToString()
        {
            return name;
        }
    }
}