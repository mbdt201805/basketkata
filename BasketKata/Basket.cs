using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();

        public Gbp Total
        {
            get
            {
                return Count(Butter) * new Gbp(0.80m) + Count(Milk) * new Gbp(1.15m);
            }
        }

        public void Add(Item item) => _items.Add(item);

        private int Count(Item item) => _items.Count(i => i == item);
    }
}