namespace BasketKata
{
    public class ButterRule
    {
        public RunningTotal ApplyButterRule(RunningTotal runningTotal)
        {
            while (runningTotal.CountButter >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter - 1, runningTotal.CountBread,
                    runningTotal.CountMilk, runningTotal.Total + new Gbp(0.80m));
            }

            return runningTotal;
        }
    }
}