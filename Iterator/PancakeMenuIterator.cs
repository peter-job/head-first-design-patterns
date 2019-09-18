using System;
using System.Collections.Generic;

namespace DinerMerger
{
    public class PancakeMenuIterator : IIterator
    {
        List<MenuItem> items;
        int position = 0;

        public PancakeMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public Object Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
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
