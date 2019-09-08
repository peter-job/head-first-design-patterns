using System;

namespace RemoteControlWithUndo
{
    public class Stereo
    {
        private string name;
        public Stereo(string name)
        {
            this.name = name;
        }
        public void On()
        {
            Console.WriteLine("{0} stereo is On", name);
        }
        public void Off()
        {
            Console.WriteLine("{0} stereo is Off", name);
        }
        public void SetCd()
        {
            Console.WriteLine("{0} stereo is set to CD", name);
        }
        public void SetDvd()
        {
            Console.WriteLine("{0} stereo is set to DVD", name);
        }
        public void SetRadio()
        {
            Console.WriteLine("{0} stereo is set to Radio", name);
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("{0} stereo is set to volume {1}", name, volume);
        }
    }
}