using static BasketKata.Item;

namespace BasketKata
{
    public class BreadAndButterRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Butter) >= 2 && runningTotal.Count(Bread) >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(2 * Butter.Price + Bread.Price / 2, Butter, Butter, Bread);
            }

            return runningTotal;
        }
    }
}