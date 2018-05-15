using NUnit.Framework;
using Shouldly;

namespace BasketKata.Tests
{
    [TestFixture]
    public class BasketShould
    {
        [Test]
        public void HaveTotalZero_WhenEmpty()
        {
            var basket = new Basket();

            var total = basket.Total;

            total.ShouldBe(new Gbp(0m));
        }
    }

    public struct Gbp
    {
        private readonly decimal _amount;

        public Gbp(decimal amount)
        {
            _amount = amount;
        }

        public override string ToString() => $"£{_amount:0.00}";
    }

    public class Basket
    {
        public Gbp Total
        {
            get
            {
                return new Gbp(0m);
            }
        }
    }
}
