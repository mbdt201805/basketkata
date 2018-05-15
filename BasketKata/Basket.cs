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

        public int CountButter { get; set; }
        public int CountBread { get; set; }
        public int CountMilk { get; set; }
        public Gbp Total { get; set; }
    }

    public class Basket
    {
        private readonly IList<Item> _items = new List<Item>();

        public void Add(Item item) => _items.Add(item);

        public Gbp Total
        {
            get
            {
                var countButter = Count(Butter);
                var countBread = Count(Bread);
                var countMilk = Count(Milk);
                var total = new Gbp(0.00m);
                return Calculate(new RunningTotal(countButter, countBread, countMilk, total));
            }
        }

        private static Gbp Calculate(RunningTotal runningTotal)
        {
            while (runningTotal.CountButter >= 2 && runningTotal.CountBread >= 1)
            {
                runningTotal.Total += new Gbp(2.10m);
                runningTotal.CountButter -= 2;
                runningTotal.CountBread -= 1;
            }

            while (runningTotal.CountMilk >= 4)
            {
                runningTotal.Total += new Gbp(3.45m);
                runningTotal.CountMilk -= 4;
            }

            while (runningTotal.CountButter >= 1)
            {
                runningTotal.CountButter -= 1;
                runningTotal.Total += new Gbp(0.80m);
            }

            while (runningTotal.CountMilk >= 1)
            {
                runningTotal.CountMilk -= 1;
                runningTotal.Total += new Gbp(1.15m);
            }

            while (runningTotal.CountBread >= 1)
            {
                runningTotal.CountBread -= 1;
                runningTotal.Total += new Gbp(1.00m);
            }

            return runningTotal.Total;
        }

        private int Count(Item item) => _items.Count(i => i == item);
    }
}