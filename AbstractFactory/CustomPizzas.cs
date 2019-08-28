using System;

namespace PizzaFactory {

    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare() {
            Console.WriteLine("Preparing {0}", name);
            sauce = ingredientFactory.CreateSauce();
            dough = ingredientFactory.CreateDough();
            cheese = ingredientFactory.CreateCheese();
        }
    }

    public class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            sauce = ingredientFactory.CreateSauce();
            dough = ingredientFactory.CreateDough();
            cheese = ingredientFactory.CreateCheese();
            veggies = ingredientFactory.CreateVeggies();
        }
    }

    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clams = ingredientFactory.CreateClams();
        }
    }

    public class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            pepperoni = ingredientFactory.CreatePepperoni();
        }
    }
}
