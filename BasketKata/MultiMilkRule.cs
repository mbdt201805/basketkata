namespace BasketKata
{
    public class MultiMilkRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.CountMilk >= 4)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter, runningTotal.CountBread,
                    runningTotal.CountMilk - 4, runningTotal.Total + new Gbp(3.45m));
            }

            return runningTotal;
        }
    }
}