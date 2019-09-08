using System;

namespace RemoteControlWithPartyMode
{
    public class Tv
    {
        private string name;

        public Tv(string name)
        {
            this.name = name;
        }

        public void On()
        {
            Console.WriteLine("{0} TV is On", name);
        }

        public void Off()
        {
            Console.WriteLine("{0} TV is Off", name);
        }

        public void SetDvd()
        {
            Console.WriteLine("{0} TV is set to DVD", name);
        }
    }
}