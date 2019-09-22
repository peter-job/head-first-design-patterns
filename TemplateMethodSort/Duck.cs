using System;

namespace DuckSort
{
    public class Duck : IComparable
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override string ToString()
        {
            return name + " weighs " + weight;
        }

        public int CompareTo(object obj)
        {
            Duck otherDuck = (Duck)obj;
            if (this.weight < otherDuck.weight)
            {
                return -1;
            }
            else if (this.weight == otherDuck.weight)
            {
                return 0;
            }
            else // if this.weight > otherDuck.weight
            {
                return 1;
            }
        }
    }
}
