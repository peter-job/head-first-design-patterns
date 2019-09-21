using System.Collections;
using System.Collections.Generic;

namespace DinerMerger
{
    public class NullEnumerator : IEnumerator<MenuComponent>
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }

        public MenuComponent Current => null;

        object IEnumerator.Current => null;

        public void Dispose()
        {
        }
    }
}
