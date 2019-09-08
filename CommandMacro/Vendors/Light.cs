using System;

namespace RemoteControlWithPartyMode
{
    public class Light
    {
        private string name;
        public Light(string name)
        {
            this.name = name;
        }
        public void On()
        {
            Console.WriteLine("{0} light is On", name);
        }
        public void Off()
        {
            Console.WriteLine("{0} light is Off", name);
        }
    }
}
