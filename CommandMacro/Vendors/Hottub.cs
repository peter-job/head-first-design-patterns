using System;

namespace RemoteControlWithPartyMode
{
    public class Hottub
    {
        public void On()
        {
            Console.WriteLine("Hottub is heating to a steaming 104 degrees");
        }
        public void Off()
        {
            Console.WriteLine("Hottub is cooling to 98 degrees");
        }
        public void SetBubbles()
        {
            Console.WriteLine("Hottub is bubbling!");
        }
    }
}