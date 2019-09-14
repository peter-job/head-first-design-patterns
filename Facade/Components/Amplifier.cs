using System;

namespace HomeTheater
{
    public class Amplifier
    {
        private readonly string name;

        public Amplifier(string name)
        {
            this.name = name;
        }

        public Tuner Tuner { get; private set; }
        public DvdPlayer Dvd { get; private set; }
        public CdPlayer Cd { get; private set; }

        public void On()
        {
            Console.WriteLine("{0} on", name);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", name);
        }

        public void SetStereoSound()
        {
            Console.WriteLine("{0} stereo mode on", name);
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("{0} surround sound on (5 speakers, 1 subwoofer)", name);
        }

        public void SetVolume(int level)
        {
            Console.WriteLine("{0} setting volume to {1}", name, level);
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine("{0} setting tunner to {2}", name, tuner);
            Tuner = tuner;
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine("{0} setting DVD player to {1}", name, dvd);
            Dvd = dvd;
        }

        public void SetCd(CdPlayer cd)
        {
            Console.WriteLine("{0} setting CD player to {1}", name, cd);
            Cd = cd;
        }

        public override string ToString()
        {
            return name;
        }
    }
}