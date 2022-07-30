namespace Dotawin.Server.Models.Dotabuff;

public class DotabuffItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Matches { get; set; }
    public double Winrate { get; set; }
    public double AddWinrate { get; set; }
    public int WinratePer1000Gold { get; set; }

    public int HeroId { get; set; }
    public DotabuffHero Hero { get; set; }
}
