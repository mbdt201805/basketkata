using static BasketKata.Item;

namespace BasketKata
{
    public class BreadRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.CountBread >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(new Gbp(1.00m), Bread);
            }

            return runningTotal;
        }
    }
}