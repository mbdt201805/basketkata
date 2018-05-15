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
                if (Count(Butter) == 2 && Count(Bread) == 1)
                    return 2 * new Gbp(0.80m) + 1 * new Gbp(0.50m);
                if (Count(Butter) == 2 && Count(Bread) == 2)
                    return 2 * new Gbp(0.80m) + 1 * new Gbp(0.50m) + 1 * new Gbp(1.00m);
                if (Count(Butter) == 4 && Count(Bread) == 4)
                    return 4 * new Gbp(0.80m) + 2 * new Gbp(0.50m) + 2 * new Gbp(1.00m);
                return ButterPrice() + MilkPrice() + BreadPrice();
            }
        }

        private Gbp ButterPrice() => Count(Butter) * new Gbp(0.80m);

        private Gbp MilkPrice() => Count(Milk) * new Gbp(1.15m);

        private Gbp BreadPrice() => Count(Bread) * new Gbp(1.00m);

        private int Count(Item item) => _items.Count(i => i == item);
    }
}