namespace PizzaFactory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("Chicago Style Deep Dish Cheese Pizza");
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.SetName("Chicago Style Deep Dish Veggie Pizza");
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("Chicago Style Deep Dish Clam Pizza");
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.SetName("Chicago Style Deep Dish Pepperoni Pizza");
                    break;
            }

            return pizza;
        }
    }
}