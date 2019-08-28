using System.Collections.Generic;

namespace PizzaFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        List<IVeggies> CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}