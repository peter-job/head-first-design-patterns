using System;

namespace RemoteControl
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
            GetSpeed();
        }
        public void Medium()
        {
            speed = "Medium";
            GetSpeed();
        }
        public void Low()
        {
            speed = "Low";
            GetSpeed();
        }
        public void Off()
        {
            speed = "Off";
            GetSpeed();
        }
        public void GetSpeed()
        {
            Console.WriteLine("{0} ceiling fan is set to {1}", name, speed);
        }
    }
}