using System;
using System.Collections;

namespace DinerMerger
{
    public class DinerMenuEnumerator : IEnumerator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuEnumerator(MenuItem[] items) {
            this.items = items;
        }

        public bool MoveNext() {
            position++;
            if (items[position] != null)
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
