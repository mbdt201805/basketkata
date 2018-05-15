using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Shouldly;
using static BasketKata.Tests.Item;

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

    public enum Item
    {
        Butter
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
        private readonly IList<Item> _items = new List<Item>();

        public Gbp Total
        {
            get
            {
                if(_items.Any())
                    return new Gbp(0.80m);
                return new Gbp(0m);
            }
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }
    }
}
