using System;

namespace PizzaFactory {

    public class CheesePizza : Pizza {
        public override void Prepare() {
            Console.WriteLine("Cheese pizza preparation technique.");
        }
    }

    public class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Veggie pizza preparation technique");
        }
    }

    public class ClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Clam pizza preparation technique");
        }
    }

    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Pepperoni pizza preparation technique");
        }
    }
}
