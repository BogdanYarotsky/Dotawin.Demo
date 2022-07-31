namespace Dotawin.Server.Models;

public class Item
{
    public int Id { get; set; }

    // Data
    public int Matches { get; set; }
    public double Winrate { get; set; }
    public double AddedWinrate { get; set; }
    public int WinratePer1000Gold { get; set; }

    // FK
    public ItemInfo Info { get; set; }
    public int InfoId { get; set; }

    // FK
    public Hero Hero { get; set; }
    public int HeroId { get; set; }

    // FK
    public Update Update { get; set; }
    public int UpdateId { get; set; }
}


