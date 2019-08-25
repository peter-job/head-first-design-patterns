namespace Starbuzz
{
    public class Espresso : Beverage
    {
        public Espresso() {
            description = "Espresso";
        }

        public override double Cost => 1.99;
    }
}
