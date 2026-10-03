namespace GildedRose.Console;

public sealed class SulfurasUpdater : IItemUpdater
{
    public bool CanHandle(Item item)
    {
        return item.Name == "Sulfuras, Hand of Ragnaros";
    }

    public void Update(Item item)
    {
        // Sulfuras never changes.
    }
}