using System;
using System.Collections;

namespace DinerMerger
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = allMenus.CreateEnumerator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotSupportedException e)
                {
                }
            }
        }
    }
}