namespace Dotawin.Server.Models;

public class ItemUpdate
{
    public int Id { get; set; }
    public string Patch { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public ICollection<ItemInfo> Items { get; set; } = new List<ItemInfo>();
}
