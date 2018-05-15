using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class RemainingBasket
    {
        private readonly IEnumerable<Item> _items;

        private RemainingBasket(IEnumerable<Item> items)
        {
            _items = items;
        }

        public int Count(Item item) => _items.Count(i => i == item);

        public static RemainingBasket FromItems(IEnumerable<Item> items) => new RemainingBasket(items);

        public RemainingBasket RemoveAll(params Item[] itemsToRemove)
        {
            var butterToRemove = itemsToRemove.Count(item => item == Butter);
            var milkToRemove = itemsToRemove.Count(item => item == Milk);
            var breadToRemove = itemsToRemove.Count(item => item == Bread);

            var countButter = Count(Butter) - butterToRemove;
            var countBread = Count(Bread) - breadToRemove;
            var countMilk = Count(Milk) - milkToRemove;

            var newItems = Enumerable.Repeat(Butter, countButter).Concat(Enumerable.Repeat(Bread, countBread))
                .Concat(Enumerable.Repeat(Milk, countMilk));

            return new RemainingBasket(newItems);
        }
    }
}