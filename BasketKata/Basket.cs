using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();

        public void Add(Item item) => _items.Add(item);

        public Gbp Total
        {
            get
            {
                return ButterPrice() + MilkPrice();
            }
        }

        private Gbp ButterPrice() => Count(Butter) * new Gbp(0.80m);

        private Gbp MilkPrice() => Count(Milk) * new Gbp(1.15m);

        private int Count(Item item) => _items.Count(i => i == item);
    }
}