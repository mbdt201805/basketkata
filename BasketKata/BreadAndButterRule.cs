using static BasketKata.Item;

namespace BasketKata
{
    public class BreadAndButterRule : IPricingRule
    {
        private readonly Item[] _qualifyingItems = { Butter, Butter, Bread };
        private readonly Gbp _rulePrice = 2 * Butter.Price + Bread.Price / 2;

        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Butter) >= 2 && runningTotal.Count(Bread) >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(_rulePrice, _qualifyingItems);
            }

            return runningTotal;
        }
    }
}