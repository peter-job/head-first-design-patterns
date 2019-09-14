using System;

namespace HomeTheater
{
    public class DvdPlayer
    {
        private readonly string description;
        private readonly Amplifier amplifier;
        private string movie;
        private int currentTrack;

        public DvdPlayer(string description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("{0} on", description);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", description);
        }

        public void Eject()
        {
            movie = null;
            Console.WriteLine("{0} eject", description);
        }

        public void Play(string movie)
        {
            this.movie = movie;
            currentTrack = 0;

            Console.WriteLine("{0} playing \"{1}\"", description, this.movie);
        }

        public void Play(int track)
        {
            if (movie == null)
            {
                Console.WriteLine("{0} can't play track {1}, no dvd inserted", description, currentTrack.ToString());
            }
            else
            {
                currentTrack = track;
                Console.WriteLine("{0} playing track {1} of \"{2}\"", description, currentTrack.ToString(), movie);
            }
        }

        public void Stop()
        {
            currentTrack = 0;
            Console.WriteLine("{0} stopped \"{1}\"", description, movie);
        }

        public void Pause()
        {
            Console.WriteLine("{0} paused \"{1}\"", description, movie);
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("{0} set to two channel audio", description);
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("{0} set to surround audio", description);
        }

        public override string ToString()
        {
            return description;
        }
    }
}