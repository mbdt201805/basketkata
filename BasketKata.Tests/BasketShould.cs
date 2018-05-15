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
    }
}
