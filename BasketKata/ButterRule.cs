using static BasketKata.Item;

namespace BasketKata
{
    public class ButterRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.CountButter >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(new Gbp(0.80m), Butter);
            }

            return runningTotal;
        }
    }
}