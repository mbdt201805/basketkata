namespace BasketKata
{
    public class MilkRule
    {
        public RunningTotal ApplyMilkRule(RunningTotal runningTotal)
        {
            while (runningTotal.CountMilk >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter, runningTotal.CountBread,
                    runningTotal.CountMilk - 1, runningTotal.Total + new Gbp(1.15m));
            }

            return runningTotal;
        }
    }
}