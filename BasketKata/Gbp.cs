namespace BasketKata
{
    public struct Gbp
    {
        private readonly decimal _amount;

        public Gbp(decimal amount)
        {
            _amount = amount;
        }

        public override string ToString() => $"£{_amount:0.00}";
    }
}