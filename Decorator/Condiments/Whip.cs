namespace Starbuzz
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + ", Whip"; }
        }

        public override double Cost => .10 + beverage.Cost;
    }
}
