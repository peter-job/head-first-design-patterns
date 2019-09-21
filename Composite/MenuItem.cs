using System;

namespace DinerMerger
{
    public class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(String name, String description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }
        public override String GetName()
        {
            return name;
        }

        public override String GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsVegetarian()
        {
            return vegetarian;
        }

        public override void Print()
        {
            Console.Write("  " + GetName());
            if (IsVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("     -- " + GetDescription());
        }
    }
}
