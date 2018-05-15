using static BasketKata.Item;

namespace BasketKata
{
    public class MilkRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.CountMilk >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(new Gbp(1.15m), Milk);
            }

            return runningTotal;
        }
    }
}