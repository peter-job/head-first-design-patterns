namespace PizzaFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory pizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public Pizza OrderPizza(string pizzaType)
        {
            var pizza = pizzaFactory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}