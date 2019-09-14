using System;

namespace HomeTheater
{
    public class HomeTheaterFacade
    {
        private Amplifier amp;
        private Tuner tuner;
        private DvdPlayer dvd;
        private CdPlayer cd;
        private Projector projector;
        private Screen screen;
        private TheaterLights lights;
        private PopcornPopper popper;

        public HomeTheaterFacade(
            Amplifier amp,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            Projector projector,
            Screen screen,
            TheaterLights lights,
            PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvdPlayer;
            this.cd = cdPlayer;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.On();
            popper.Pop();
            lights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amp.On();
            amp.SetDvd(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }

        public void ListenToCd(string cdTitle)
        {
            Console.WriteLine("Get ready for an audiopile experience...");
            lights.On();
            amp.On();
            amp.SetVolume(5);
            amp.SetCd(cd);
            amp.SetStereoSound();
            cd.On();
            cd.Play(cdTitle);
        }

        public void EndCd()
        {
            Console.WriteLine("Shutting down CD...");
            amp.Off();
            amp.SetCd(cd);
            cd.Eject();
            cd.Off();
        }

        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            tuner.On();
            tuner.SetFrequency(frequency);
            amp.On();
            amp.SetVolume(5);
            amp.SetTuner(tuner);
        }

        public void EndRadio()
        {
            Console.WriteLine("Shutting down the tuner...");
            tuner.Off();
            amp.Off();
        }
    }
}