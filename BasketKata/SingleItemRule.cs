namespace BasketKata
{
    public class SingleItemRule : IPricingRule
    {
        private readonly Item _item;

        public SingleItemRule(Item item)
        {
            _item = item;
        }

        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(_item) >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(_item.Price, _item);
            }

            return runningTotal;
        }
    }
}