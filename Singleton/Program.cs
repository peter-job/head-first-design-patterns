using System;

namespace ChocolateBoiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var boiler1 = ChocolateBoiler.GetInstance();
            var boiler2 = ChocolateBoiler.GetInstance();

            if (!boiler1.IsBoiled()) {
                Console.WriteLine("Boiler 1 is cold");
            }
            if (!boiler2.IsBoiled()) {
                Console.WriteLine("Boiler 2 is cold");
            }
            Console.WriteLine("Turning on Boiler 1...");
            boiler1.Boil();
            if (boiler1.IsBoiled())
            {
                Console.WriteLine("Boiler 1 is boiled!");
            }
            if (boiler2.IsBoiled())
            {
                Console.WriteLine("So is Boiler 2!");
            }

            if (boiler1 == boiler2)
            {
                Console.WriteLine("GetInstance returns the same chocolate boiler each time!");
            }
            else
            {
                Console.WriteLine("GetInstance returns different chocolate boilers each time!");
            }
        }
    }
}
