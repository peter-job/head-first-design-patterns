using System;
using System.Collections;

namespace DinerMerger
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;
        CafeMenu cafeMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu, CafeMenu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            IEnumerator pancakeEnumerator = pancakeHouseMenu.GetEnumerator();
            IEnumerator dinerEnumerator = dinerMenu.GetEnumerator();
            IEnumerator cafeEnumerator = cafeMenu.GetEnumerator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeEnumerator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerEnumerator);
            Console.WriteLine("\nDINNER");
            PrintMenu(cafeEnumerator);
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