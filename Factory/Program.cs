using System;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(pizzaFactory);

            pizzaStore.OrderPizza("cheese");
        }
    }
  }
