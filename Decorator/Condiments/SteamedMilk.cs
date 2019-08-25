namespace Starbuzz
{
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + ", Steamed Milk"; }
        }

        public override double Cost => .10 + beverage.Cost;
    }
}
