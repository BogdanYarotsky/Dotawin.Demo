namespace Dotawin.Server.Models;

public class Item
{
    public enum Type
    {
        Boots, Core, Neutral, Situational
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Matches { get; set; }
    public double Winrate { get; set; }
    public double AddWinrate { get; set; }
    public int WinratePer1000Gold { get; set; }
    public int Cost { get; set; }

    public int HeroId { get; set; }
    public Hero Hero { get; set; }
}
