using System;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a {0} pizza.", pizza.GetName());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a {0} pizza.", pizza.GetName());
        }
    }
  }
