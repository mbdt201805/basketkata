﻿namespace BasketKata
{
    public class BreadRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.CountBread >= 1)
            {
                runningTotal = new RunningTotal(runningTotal.CountButter, runningTotal.CountBread - 1,
                    runningTotal.CountMilk, runningTotal.Total + new Gbp(1.00m));
            }

            return runningTotal;
        }
    }
}