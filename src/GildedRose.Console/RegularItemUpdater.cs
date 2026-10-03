namespace GildedRose.Console;

public sealed class RegularItemUpdater : IItemUpdater
{
    public bool CanHandle(Item item)
    {
        return !item.Name.StartsWith("Conjured", StringComparison.Ordinal)
            && item.Name != "Aged Brie"
            && item.Name != "Backstage passes to a TAFKAL80ETC concert"
            && item.Name != "Sulfuras, Hand of Ragnaros";
    }

    public void Update(Item item)
    {
        DecreaseQuality(item, 1);

        item.SellIn--;

        if (item.SellIn < 0)
        {
            DecreaseQuality(item, 1);
        }
    }

    private static void DecreaseQuality(Item item, int amount)
    {
        item.Quality = Math.Max(0, item.Quality - amount);
    }
}