using static BasketKata.Item;

namespace BasketKata
{
    public class MultiMilkRule : IPricingRule
    {
        private readonly Item[] _qualifyingItems = {Milk, Milk, Milk, Milk};
        private readonly Gbp _rulePrice = 3 * Milk.Price;

        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Milk) >= 4)
            {
                runningTotal = runningTotal.ApplyPrice(_rulePrice, _qualifyingItems);
            }

            return runningTotal;
        }
    }
}