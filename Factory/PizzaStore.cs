namespace PizzaFactory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            var pizza = this.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string pizzaType);
    }
}