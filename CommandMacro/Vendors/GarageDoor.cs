using System;

namespace RemoteControlWithPartyMode
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is Down");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door is Stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door light is Off");
        }
    }
}
