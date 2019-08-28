using System;
using System.Collections.Generic;

namespace PizzaFactory
{
    public abstract class Pizza
    {
        protected string name;
        protected IDough dough;
        protected ISauce sauce;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clams;
        protected List<IVeggies> veggies;

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 mins at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}