using System;

namespace HomeTheater
{
    public class CdPlayer
    {
        private readonly string name;
        private readonly Amplifier amplifier;
        private string title;
        private int currentTrack;

        public CdPlayer(string name, Amplifier amplifier)
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

        public void Eject()
        {
            title = null;
            Console.WriteLine("{0} eject", name);
        }

        public void Play(string title)
        {
            this.title = title;
            currentTrack = 0;

            Console.WriteLine("{0} playing \"{1}\"", name, title);
        }

        public void Play(int track)
        {
            if (title == null)
            {
                Console.WriteLine("{0} can't play track {1}, no cd inserted", name, track);
            }
            else
            {
                currentTrack = track;
                Console.WriteLine("{0} playing track {1}", name, track);
            }
        }

        public void Stop()
        {
            currentTrack = 0;
            Console.WriteLine("{0} stopped", name);
        }

        public void Pause()
        {
            Console.WriteLine("{0} paused \"{1}\"", name, title);
        }

        public override string ToString()
        {
            return name;
        }
    }
}