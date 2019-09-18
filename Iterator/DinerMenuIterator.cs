using System;

namespace DinerMerger
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items) {
            this.items = items;
        }

        public Object Next() {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
