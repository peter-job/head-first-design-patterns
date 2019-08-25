namespace Starbuzz
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string Description {
            get { return description; }
        }

        public virtual double Cost { get; }
    }
}
