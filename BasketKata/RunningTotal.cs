using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class RunningTotal
    {
        public RunningTotal(int countButter, int countBread, int countMilk, Gbp total)
        {
            CountButter = countButter;
            CountBread = countBread;
            CountMilk = countMilk;
            Total = total;
        }

        public int CountButter { get; }
        public int CountBread { get; }
        public int CountMilk { get; }
        public Gbp Total { get; }

        public static RunningTotal FromItems(IList<Item> items) => new RunningTotal(Count(items, Butter), Count(items, Bread), Count(items, Milk), new Gbp(0.00m));

        private static int Count(IEnumerable<Item> items, Item item) => items.Count(i => i == item);
    }
}