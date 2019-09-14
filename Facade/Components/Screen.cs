using System;

namespace HomeTheater
{
    public class Screen
    {
        private readonly string name;

        public Screen(string name)
        {
            this.name = name;
        }

        public void Up()
        {
            Console.WriteLine("{0} going up", name);
        }

        public void Down()
        {
            Console.WriteLine("{0} going down", name);
        }

        public override string ToString()
        {
            return name;
        }
    }
}