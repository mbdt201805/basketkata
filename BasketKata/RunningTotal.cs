using System.Collections.Generic;

namespace BasketKata
{
    public class RunningTotal
    {
        public static RunningTotal FromItems(IEnumerable<Item> items) => new RunningTotal(RemainingBasket.FromItems(items), new Gbp(0.00m));

        private readonly RemainingBasket _remainingBasket;

        private RunningTotal(RemainingBasket remainingBasket, Gbp total)
        {
            _remainingBasket = remainingBasket;
            Total = total;
        }

        public int Count(Item item) => _remainingBasket.Count(item);

        public Gbp Total { get; }

        public RunningTotal ApplyPrice(Gbp price, params Item[] items) => new RunningTotal(_remainingBasket.Without(items), Total + price);
    }
}