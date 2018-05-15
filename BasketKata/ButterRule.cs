using static BasketKata.Item;

namespace BasketKata
{
    public class ButterRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Butter) >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(Butter.Price, Butter);
            }

            return runningTotal;
        }
    }
}