using System.Collections.Generic;
using System.Linq;
using static BasketKata.Item;

namespace BasketKata
{
    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();

        public void Add(Item item) => _items.Add(item);

        public Gbp Total => Calculate(new RunningTotal(Count(Butter), Count(Bread), Count(Milk), new Gbp(0.00m))).Total;

        private static RunningTotal Calculate(RunningTotal runningTotal)
        {
            while (runningTotal.CountButter >= 2 && runningTotal.CountBread >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter - 2, runningTotal.CountBread - 1,
                    runningTotal.CountMilk, runningTotal.Total + new Gbp(2.10m));
            }

            while (runningTotal.CountMilk >= 4)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter, runningTotal.CountBread,
                    runningTotal.CountMilk -4, runningTotal.Total+ new Gbp(3.45m));
            }

            while (runningTotal.CountButter >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter - 1, runningTotal.CountBread,
                    runningTotal.CountMilk, runningTotal.Total + new Gbp(0.80m));
            }

            while (runningTotal.CountMilk >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter, runningTotal.CountBread,
                    runningTotal.CountMilk - 1, runningTotal.Total + new Gbp(1.15m));
            }

            while (runningTotal.CountBread >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter, runningTotal.CountBread - 1,
                    runningTotal.CountMilk, runningTotal.Total + new Gbp(1.00m));
            }

            return runningTotal;
        }

        private int Count(Item item) => _items.Count(i => i == item);
    }
}