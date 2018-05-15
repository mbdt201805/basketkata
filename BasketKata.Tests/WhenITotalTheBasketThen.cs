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
        public void TheTotalShouldBe80Pence_GivenTheBasketHas1Butter()
        {
            var basket = new Basket();
            basket.Add(Butter);

            var total = basket.Total;

            total.ShouldBe(new Gbp(0.80m));
        }

        [Test]
        public void TheTotalShouldBe1Pound60_GivenTheBasketHas2Butter()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Butter);

            var total = basket.Total;

            total.ShouldBe(new Gbp(1.60m));
        }

        [Test]
        public void TheTotalShouldBe1Pound95_GivenTheBasketHas1ButterAnd1Milk()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Milk);

            var total = basket.Total;

            total.ShouldBe(new Gbp(1.95m));
        }

        [Test]
        public void TheTotalShouldBe3Pounds90_GivenTheBasketHas2ButterAnd2Milk()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Milk);
            basket.Add(Butter);
            basket.Add(Milk);

            var total = basket.Total;

            total.ShouldBe(new Gbp(3.90m));
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
        public void TheTotalShouldBe2Pounds10_GivenTheBasketHas2ButterAnd1Bread()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Butter);
            basket.Add(Bread);

            var total = basket.Total;

            total.ShouldBe(new Gbp(2.10m));
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

    }
}
