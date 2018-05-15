namespace BasketKata
{
    public abstract class Item
    {
        public static Item Butter { get; } = new ButterItem();
        public static Item Milk { get; } = new MilkItem();
        public static Item Bread { get; } = new BreadItem();

        public abstract Gbp Price { get; }

        private class ButterItem : Item
        {
            public override Gbp Price => new Gbp(0.80m);
        }

        private class MilkItem : Item
        {
            public override Gbp Price => new Gbp(1.15m);
        }

        private class BreadItem : Item
        {
            public override Gbp Price => new Gbp(1.00m);
        }
    }
}