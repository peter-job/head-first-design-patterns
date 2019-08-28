using System;
using System.Collections.Generic;

namespace PizzaFactory
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");

            foreach (var topping in toppings) {
                Console.WriteLine("\t{0}", topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 mins at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual string GetName()
        {
            return name;
        }
    }
}