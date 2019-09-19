using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMerger
{
    public class PancakeMenuEnumerator : IEnumerator
    {
        List<MenuItem> items;
        int position = 0;

        public PancakeMenuEnumerator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool MoveNext()
        {
            position++;
            if (position < items.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = 0;
        }

        public object Current => items[position];
    }
}
