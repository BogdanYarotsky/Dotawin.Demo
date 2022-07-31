namespace Dotawin.Server.Models;

public class Update
{
    public int Id { get; set; }

    //Data
    public DateTimeOffset DateTime { get; set; }

    // FK
    public ICollection<Hero> Heroes { get; set; } = new List<Hero>();
    public ICollection<Item> Items { get; set; } = new List<Item>();
}
