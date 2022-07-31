namespace Dotawin.Server.Models;

public class Hero
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsCarry { get; set; }
    public int Popularity { get; set; }
    public double Winrate { get; set; }

    // FK
    public int UpdateId { get; set; }
    public Update Update { get; set; }

    // FK
    public ICollection<Item> Items { get; set; } = new List<Item>();
}
