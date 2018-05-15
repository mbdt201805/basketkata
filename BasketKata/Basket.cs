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
                {
                    total += new Gbp(2.10m);
                    countButter -= 2;
                    countBread -= 1;
                }

                if (countButter == 2 && countBread == 2)
                {
                    total += new Gbp(2.10m);
                    countButter -= 2;
                    countBread -= 1;
                }
                if (countButter == 4 && countBread == 4)
                {
                    total += new Gbp(4.20m);
                    countButter -= 4;
                    countBread -= 2;
                }

                total += countButter * new Gbp(0.80m);
                total += countMilk * new Gbp(1.15m);
                total += countBread * new Gbp(1.00m);
                return total;
            }
        }

        private int Count(Item item) => _items.Count(i => i == item);
    }
}