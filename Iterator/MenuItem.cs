using System;

namespace DinerMerger
{
    public class MenuItem
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
        public String GetName() { return name; }
        public String GetDescription() { return description; }
        public double GetPrice() { return price; }
        public bool IsVegetarian() { return vegetarian; }
    }
}
