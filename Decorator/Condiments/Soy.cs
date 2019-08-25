namespace Starbuzz
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + ", Soy"; }
        }

        public override double Cost => .15 + beverage.Cost;
    }
}
