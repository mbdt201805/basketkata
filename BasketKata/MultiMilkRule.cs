using static BasketKata.Item;

namespace BasketKata
{
    public class MultiMilkRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Milk) >= 4)
            {
                runningTotal = runningTotal.ApplyPrice(new Gbp(3.45m), Milk, Milk, Milk, Milk);
            }

            return runningTotal;
        }
    }
}