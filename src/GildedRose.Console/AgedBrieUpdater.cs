namespace GildedRose.Console;

public sealed class AgedBrieUpdater : IItemUpdater
{
    public bool CanHandle(Item item)
    {
        return item.Name == "Aged Brie";
    }

    public void Update(Item item)
    {
        item.SellIn--;

        IncreaseQuality(item, 1);

        if (item.SellIn < 0)
        {
            IncreaseQuality(item, 1);
        }
    }

    private static void IncreaseQuality(Item item, int amount)
    {
        item.Quality = Math.Min(50, item.Quality + amount);
    }
}