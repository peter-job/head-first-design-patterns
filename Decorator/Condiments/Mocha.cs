namespace Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + ", Mocha"; } 
        }

        public override double Cost => .20 + beverage.Cost;
    }
}
