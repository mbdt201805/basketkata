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
                return countButter * new Gbp(0.80m) + countMilk * new Gbp(1.15m);
            }
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }
    }
}