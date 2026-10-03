namespace GildedRose.Console;

public sealed class BackstagePassUpdater : IItemUpdater
{
    public bool CanHandle(Item item)
    {
        return item.Name ==
            "Backstage passes to a TAFKAL80ETC concert";
    }

    public void Update(Item item)
    {
        item.SellIn--;

        // After the concert, quality becomes zero.
        if (item.SellIn < 0)
        {
            item.Quality = 0;
            return;
        }

        // Normal increase.
        IncreaseQuality(item, 1);

        // 10 days or less.
        if (item.SellIn < 10)
        {
            IncreaseQuality(item, 1);
        }

        // 5 days or less.
        if (item.SellIn < 5)
        {
            IncreaseQuality(item, 1);
        }
    }

    private static void IncreaseQuality(Item item, int amount)
    {
        item.Quality = Math.Min(50, item.Quality + amount);
    }
}