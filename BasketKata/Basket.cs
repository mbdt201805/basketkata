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
                var countButter = Count(Butter);
                var countMilk = Count(Milk);
                var countBread = Count(Bread);
                var total = new Gbp(0.00m);
                if (countButter == 2 && countBread == 1)
                    return 2 * new Gbp(0.80m) + 1 * new Gbp(0.50m);
                if (countButter == 2 && countBread == 2)
                    return 2 * new Gbp(0.80m) + 1 * new Gbp(0.50m) + 1 * new Gbp(1.00m);
                if (countButter == 4 && countBread == 4)
                    return 4 * new Gbp(0.80m) + 2 * new Gbp(0.50m) + 2 * new Gbp(1.00m);
                total += countButter * new Gbp(0.80m);
                total += countMilk * new Gbp(1.15m);
                total += countBread * new Gbp(1.00m);
                return total;
            }
        }

        private int Count(Item item) => _items.Count(i => i == item);
    }
}