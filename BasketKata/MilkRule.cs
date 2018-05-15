using static BasketKata.Item;

namespace BasketKata
{
    public class MilkRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Milk) >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(Milk.Price, Milk);
            }

            return runningTotal;
        }
    }
}