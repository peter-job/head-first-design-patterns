using System;

namespace Barista
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = getUserInput();
            var firstLetter = answer.Substring(0, 1).ToLower();
            return firstLetter == "y";
        }

        private string getUserInput()
        {
            Console.Write("Would you like milk and sugar with your coffee sir (y/n)? > ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
