namespace Dotawin.Server.Models;

public class Item
{
    public int Id { get; set; }
    public ItemType Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Matches { get; set; }
    public double Winrate { get; set; }
    public double AddedWinrate { get; set; }
    public int WinratePer1000Gold { get; set; }
    public int Cost { get; set; }
    public int HeroId { get; set; }
    public Hero Hero { get; set; }
}

public enum ItemType
{
    Boots, Core, Neutral, Situational
}
