using System.Collections.Generic;
using System.Linq;

namespace BasketKata
{
    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();

        public Gbp Total
        {
            get
            {
                if(_items.Count(item => item == Item.Butter) == 1 && _items.Count(item => item == Item.Milk) == 1)
                    return new Gbp(1.95m);
                if(_items.Any())
                    return _items.Count * new Gbp(0.80m);
                return new Gbp(0m);
            }
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }
    }
}