namespace GildedRose.Console;

public sealed class ConjuredItemUpdater : IItemUpdater
{
    public bool CanHandle(Item item)
    {
        return item.Name.StartsWith(
            "Conjured",
            StringComparison.Ordinal);
    }

    public void Update(Item item)
    {
        DecreaseQuality(item, 2);

        item.SellIn--;

        if (item.SellIn < 0)
        {
            DecreaseQuality(item, 2);
        }
    }

    private static void DecreaseQuality(Item item, int amount)
    {
        item.Quality = Math.Max(0, item.Quality - amount);
    }
}