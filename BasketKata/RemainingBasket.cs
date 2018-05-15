using System.Collections.Generic;
using System.Linq;

namespace BasketKata
{
    public class RemainingBasket
    {
        private RemainingBasket(int countButter, int countBread, int countMilk)
        {
            CountButter = countButter;
            CountBread = countBread;
            CountMilk = countMilk;
        }

        public int CountButter { get; }
        public int CountBread { get; }
        public int CountMilk { get; }

        public static RemainingBasket FromItems(IList<Item> items) => new RemainingBasket(Count(items, Item.Butter), Count(items, Item.Bread), Count(items, Item.Milk));

        private static int Count(IEnumerable<Item> items, Item item) => items.Count(i => i == item);

        public RemainingBasket RemoveAll(params Item[] itemsToRemove)
        {
            var butterToRemove = itemsToRemove.Count(item => item == Item.Butter);
            var milkToRemove = itemsToRemove.Count(item => item == Item.Milk);
            var breadToRemove = itemsToRemove.Count(item => item == Item.Bread);

            return new RemainingBasket(CountButter - butterToRemove,CountBread - breadToRemove, CountMilk - milkToRemove);
        }
    }
}