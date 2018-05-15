using System.Collections.Generic;

namespace BasketKata
{
    public class RunningTotal
    {
        public static RunningTotal FromItems(IList<Item> items) => new RunningTotal(RemainingBasket.FromItems(items), new Gbp(0.00m));

        private readonly RemainingBasket _remainingBasket;

        private RunningTotal(RemainingBasket remainingBasket, Gbp total)
        {
            _remainingBasket = remainingBasket;
            Total = total;
        }

        public int CountButter => _remainingBasket.CountButter;
        public int CountBread => _remainingBasket.CountBread;
        public int CountMilk => _remainingBasket.CountMilk;
        public Gbp Total { get; }

        public RunningTotal ApplyPrice(Gbp price, params Item[] items) => new RunningTotal(_remainingBasket.RemoveAll(items), Total + price);
    }
}