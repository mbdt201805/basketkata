using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();
        private readonly BreadAndButterRule _breadAndButterRule = new BreadAndButterRule();
        private readonly MultiMilkRule _multiMilkRule = new MultiMilkRule();
        private readonly ButterRule _butterRule = new ButterRule();
        private readonly MilkRule _milkRule = new MilkRule();
        private readonly BreadRule _breadRule = new BreadRule();

        public void Add(Item item) => _items.Add(item);

        public Gbp Total => Calculate(new RunningTotal(Count(Butter), Count(Bread), Count(Milk), new Gbp(0.00m))).Total;

        private RunningTotal Calculate(RunningTotal runningTotal)
        {
            var rules = new IPricingRule[] {_breadAndButterRule, _multiMilkRule, _butterRule, _milkRule, _breadRule};

            return rules.Aggregate(runningTotal, (rt, rule) => rule.Apply(rt));
        }

        private int Count(Item item) => _items.Count(i => i == item);
    }
}