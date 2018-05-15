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
                var total = new Gbp(0.00m);
                if (Count(Butter) == 2 && Count(Bread) == 1)
                    return 2 * new Gbp(0.80m) + 1 * new Gbp(0.50m);
                if (Count(Butter) == 2 && Count(Bread) == 2)
                    return 2 * new Gbp(0.80m) + 1 * new Gbp(0.50m) + 1 * new Gbp(1.00m);
                if (Count(Butter) == 4 && Count(Bread) == 4)
                    return 4 * new Gbp(0.80m) + 2 * new Gbp(0.50m) + 2 * new Gbp(1.00m);
                total += Count(Butter) * new Gbp(0.80m);
                total += Count(Milk) * new Gbp(1.15m);
                total += Count(Bread) * new Gbp(1.00m);
                return total;
            }
        }

        private int Count(Item item) => _items.Count(i => i == item);
    }
}