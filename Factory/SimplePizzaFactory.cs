namespace PizzaFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            switch (pizzaType) {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
            }

            return pizza;
        }
    }
}