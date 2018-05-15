using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();
        private readonly IPricingRule[] _pricingRules;

        public Basket()
        {
            _pricingRules = new IPricingRule[]
            {
                new BreadAndButterRule(),
                new MultiMilkRule(),
                new SingleItemRule(Butter),
                new SingleItemRule(Milk),
                new SingleItemRule(Bread)
            };
        }

        public void Add(Item item) => _items.Add(item);

        public Gbp Total => _pricingRules.Aggregate(RunningTotal.FromItems(_items), (runningTotal, rule) => rule.Apply(runningTotal)).Total;
    }
}