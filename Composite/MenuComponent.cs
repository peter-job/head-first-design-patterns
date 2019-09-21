using System;
using System.Collections.Generic;

namespace DinerMerger
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual String GetName()
        {
            throw new NotSupportedException();
        }

        public virtual String GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new NullEnumerator();
        }
    }
}
