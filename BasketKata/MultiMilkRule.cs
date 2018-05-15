using static BasketKata.Item;

namespace BasketKata
{
    public class MultiMilkRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Milk) >= 4)
            {
                runningTotal = runningTotal.ApplyPrice(3 * Milk.Price, Milk, Milk, Milk, Milk);
            }

            return runningTotal;
        }
    }
}