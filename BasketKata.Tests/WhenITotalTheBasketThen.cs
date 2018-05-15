using NUnit.Framework;
using Shouldly;
using static BasketKata.Item;

namespace BasketKata.Tests
{
    [TestFixture]
    public class WhenITotalTheBasketThen
    {
        [Test]
        public void TheTotalShouldBeZero_GivenTheBaketIsEmpty()
        {
            var basket = new Basket();

            var total = basket.Total;

            total.ShouldBe(new Gbp(0m));
        }

        [Test]
        public void TheTotalShouldBe2Pounds95_GivenTheBasketHas1Butter1MilkAnd1Bread()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Milk);
            basket.Add(Bread);

            var total = basket.Total;

            total.ShouldBe(new Gbp(2.95m));
        }

        [Test]
        public void TheTotalShouldBe3Pounds10_GivenTheBasketHas2ButterAnd2Bread()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Butter);
            basket.Add(Bread);
            basket.Add(Bread);

            var total = basket.Total;

            total.ShouldBe(new Gbp(3.10m));
        }

        [Test]
        public void TheTotalShouldBe9Pounds00_GivenTheBasketHas2Butter1BreadAnd8Milk()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Butter);
            basket.Add(Bread);
            basket.Add(Milk);
            basket.Add(Milk);
            basket.Add(Milk);
            basket.Add(Milk);
            basket.Add(Milk);
            basket.Add(Milk);
            basket.Add(Milk);
            basket.Add(Milk);

            var total = basket.Total;

            total.ShouldBe(new Gbp(9.00m));
        }

    }
}
