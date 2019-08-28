namespace PizzaFactory
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("New York Style Cheese Pizza");
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.SetName("New York Style Veggie Pizza");
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("New York Style Clam Pizza");
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.SetName("New York Style Pepperoni Pizza");
                    break;
            }

            return pizza;
        }
    }
}