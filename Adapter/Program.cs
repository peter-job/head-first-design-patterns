using System;

namespace TurkeyAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says...");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("\nThe TurkeyAdapter says...");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }
    }
}
