using System;
using System.Collections;

namespace DinerMerger
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu; this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IEnumerator pancakeIterator = pancakeHouseMenu.GetEnumerator();
            IEnumerator dinerIterator = dinerMenu.GetEnumerator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)enumerator.Current;
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}