using System;

namespace HomeTheater
{
    public class Tuner
    {
        private readonly string name;
        private readonly Amplifier amplifier;
        private double frequency;

        public Tuner(string name, Amplifier amplifier)
        {
            this.name = name;
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("{0} on", name);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", name);
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine("{0} setting frequency to {1:0.0}", name, frequency);
            this.frequency = frequency;
        }

        public void SetAm()
        {
            Console.WriteLine("{0} setting AM mode", name);
        }

        public void SetFm()
        {
            Console.WriteLine("{0} setting FM mode", name);
        }

        public override string ToString()
        {
            return name;
        }
    }
}