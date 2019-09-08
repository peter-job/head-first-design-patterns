using System;

namespace RemoteControlWithUndo
{
    public class CeilingFan
    {
        private string name;
        private string speed = "Off";

        public CeilingFan(string name)
        {
            this.name = name;
        }
        public void High()
        {
            speed = "High";
            Console.WriteLine("{0} ceiling fan is set to {1}", name, speed);
        }
        public void Medium()
        {
            speed = "Medium";
            Console.WriteLine("{0} ceiling fan is set to {1}", name, speed);
        }
        public void Low()
        {
            speed = "Low";
            Console.WriteLine("{0} ceiling fan is set to {1}", name, speed);
        }
        public void Off()
        {
            speed = "Off";
            Console.WriteLine("{0} ceiling fan is set to {1}", name, speed);
        }
        public string GetSpeed()
        {
            return speed;
        }
    }
}