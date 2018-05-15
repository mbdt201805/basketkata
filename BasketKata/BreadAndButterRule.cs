using static BasketKata.Item;

namespace BasketKata
{
    public class BreadAndButterRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.CountButter >= 2 && runningTotal.CountBread >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(new Gbp(2.10m), Bread, Butter, Butter);
            }

            return runningTotal;
        }
    }
}