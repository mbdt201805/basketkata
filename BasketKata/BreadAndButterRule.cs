namespace BasketKata
{
    public class BreadAndButterRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.CountButter >= 2 && runningTotal.CountBread >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter - 2, runningTotal.CountBread - 1,
                    runningTotal.CountMilk, runningTotal.Total + new Gbp(2.10m));
            }

            return runningTotal;
        }
    }
}