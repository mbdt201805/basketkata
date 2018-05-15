namespace BasketKata
{
    public abstract class Item
    {
        public static Item Butter { get; } = new ButterItem();
        public static Item Milk { get; } = new MilkItem();
        public static Item Bread { get; } = new BreadItem();

        private class ButterItem : Item { }
        private class MilkItem : Item { }
        private class BreadItem : Item { }
    }
}