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

        public static Gbp operator *(int multiplier, Gbp value) => new Gbp(multiplier * value._amount);

        public static Gbp operator +(Gbp lhs, Gbp rhs) => new Gbp(lhs._amount + rhs._amount);
    }
}