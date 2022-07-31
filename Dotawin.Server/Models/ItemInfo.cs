namespace Dotawin.Server.Models;

public class ItemInfo
{
    public int Id { get; set; }
    public ItemType Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Cost { get; set; }
    public ICollection<Item> Items { get; set; } = new List<Item>();

    // FK
    public int UpdateId { get; set; }
    public ItemUpdate Update { get; set; }
}

public enum ItemType
{
    Boots, Core, Neutral, Situational
}