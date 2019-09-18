using System;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine("Making tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.PrepareRecipe();
        }
    }
}
