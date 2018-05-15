using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class RemainingBasket
    {
        public static RemainingBasket FromItems(IEnumerable<Item> items) => new RemainingBasket(items);

        private readonly IEnumerable<Item> _items;

        private RemainingBasket(IEnumerable<Item> items)
        {
            _items = items;
        }

        public int Count(Item item) => _items.Count(i => i == item);

        public RemainingBasket Without(IEnumerable<Item> itemsToRemove) => new RemainingBasket(ItemsWithout(itemsToRemove));

        private IEnumerable<Item> ItemsWithout(IEnumerable<Item> itemsToRemove)
        {
            var copyOfItems = new List<Item>(_items);
            foreach (var item in itemsToRemove)
            {
                copyOfItems.Remove(item);
            }
            return copyOfItems;
        }
    }
}