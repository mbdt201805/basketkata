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
    }
}