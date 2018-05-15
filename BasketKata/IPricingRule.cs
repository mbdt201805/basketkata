namespace BasketKata
{
    public interface IPricingRule
    {
        RunningTotal Apply(RunningTotal runningTotal);
    }
}