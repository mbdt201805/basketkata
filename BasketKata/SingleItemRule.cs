namespace BasketKata
{
    public class SingleItemRule : IPricingRule
    {
        private readonly Item _qualifyingItem;

        public SingleItemRule(Item qualifyingItem)
        {
            _qualifyingItem = qualifyingItem;
        }

        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(_qualifyingItem) >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(_qualifyingItem.Price, _qualifyingItem);
            }

            return runningTotal;
        }
    }
}