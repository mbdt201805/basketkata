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
                new ButterRule(),
                new MilkRule(),
                new BreadRule()
            };
        }

        public void Add(Item item) => _items.Add(item);

        public Gbp Total => Calculate(RunningTotal.FromItems(_items)).Total;

        private RunningTotal Calculate(RunningTotal runningTotal)
        {
            return _pricingRules.Aggregate(runningTotal, (rt, rule) => rule.Apply(rt));
        }
    }
}