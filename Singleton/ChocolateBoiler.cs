namespace ChocolateBoiler
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler uniqueInstance;

        private ChocolateBoiler()
        {
        }

        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }

        public void Fill() {
            if (IsEmpty()) {
                empty = false;
                boiled = false;
            }
        }

        public void Drain() {
            if (IsEmpty() && IsBoiled())
            {
                empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }
}
