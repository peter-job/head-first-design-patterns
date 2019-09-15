using System;

namespace Barista
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = getUserInput();
            var firstLetter = answer.Substring(0, 1).ToLower();
            return firstLetter == "y";
        }

        private string getUserInput()
        {
            Console.Write("Would you like lemon with your tea sir (y/n)? > ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
