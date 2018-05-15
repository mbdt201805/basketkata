﻿using static BasketKata.Item;

namespace BasketKata
{
    public class BreadRule : IPricingRule
    {
        public RunningTotal Apply(RunningTotal runningTotal)
        {
            while (runningTotal.Count(Bread) >= 1)
            {
                runningTotal = runningTotal.ApplyPrice(Bread.Price, Bread);
            }

            return runningTotal;
        }
    }
}