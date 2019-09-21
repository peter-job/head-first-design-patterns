using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMerger
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents;
        string name;
        string description;

        public Menu(string name, string description)
        {
            menuComponents = new List<MenuComponent>();
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i) {
            return (MenuComponent)menuComponents[i];
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override void Print() {
            Console.Write("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            IEnumerator enumerator = menuComponents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new CompositeEnumerator(menuComponents.GetEnumerator());
        }
    }
}
