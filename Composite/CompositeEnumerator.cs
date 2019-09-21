using System;
using System.Collections;
using System.Collections.Generic;

namespace DinerMerger
{
    public class CompositeEnumerator : IEnumerator<MenuComponent>
    {
        private readonly Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();

        public CompositeEnumerator(IEnumerator<MenuComponent> enumerator)
        {
            stack.Push(enumerator);
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }

            var enumerator = stack.Peek();
            if (!enumerator.MoveNext())
            {
                stack.Pop();
                return MoveNext();
            }

            return true;
        }

        public MenuComponent Current
        {
            get
            {
                var enumerator = stack.Peek();
                var menuComponent = enumerator.Current;
                if (menuComponent is Menu)
                {
                    stack.Push(menuComponent.CreateEnumerator());
                }
                return menuComponent;
            }
        }

        object IEnumerator.Current => Current;

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
        }
    }
}
