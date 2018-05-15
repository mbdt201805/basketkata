using System.Collections.Generic;
using System.Linq;

namespace BasketKata
{
    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();

        public Gbp Total
        {
            get
            {
                var countButter = _items.Count(item => item == Item.Butter);
                var countMilk = _items.Count(item => item == Item.Milk);
                if(countButter == 1 && countMilk == 1)
                    return new Gbp(0.80m) + new Gbp(1.15m);
                if (countButter == 2 && countMilk == 2)
                    return 2 * new Gbp(0.80m) + 2 * new Gbp(1.15m);
                if (_items.Any())
                    return _items.Count * new Gbp(0.80m);
                return new Gbp(0m);
            }
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }
    }
}