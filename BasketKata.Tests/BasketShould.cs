using NUnit.Framework;
using Shouldly;
using static BasketKata.Item;

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

        [Test]
        public void HaveTotal80Pence_WhenItHas1Butter()
        {
            var basket = new Basket();
            basket.Add(Butter);

            var total = basket.Total;

            total.ShouldBe(new Gbp(0.80m));
        }

        [Test]
        public void HaveTotal1Pound60_WhenItHas2Butter()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Butter);

            var total = basket.Total;

            total.ShouldBe(new Gbp(1.60m));
        }

        [Test]
        public void HaveTotal1Pound95_WhenItHas1Butter1Milk()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Milk);

            var total = basket.Total;

            total.ShouldBe(new Gbp(1.95m));
        }

        [Test]
        public void HaveTotal3Pounds90_WhenItHAs2Butter2Milk()
        {
            var basket = new Basket();
            basket.Add(Butter);
            basket.Add(Milk);
            basket.Add(Butter);
            basket.Add(Milk);

            var total = basket.Total;

            total.ShouldBe(new Gbp(3.90m));
        }
    }
}
