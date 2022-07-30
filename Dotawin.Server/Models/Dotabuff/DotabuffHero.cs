namespace Dotawin.Server.Models.Dotabuff;

public class DotabuffHero
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsCarry { get; set; }
    public int Popularity { get; set; }
    public double Winrate { get; set; }
    public ICollection<DotabuffItem> Items { get; set; } = new List<DotabuffItem>();

    public int UpdateId { get; set; }
    public DotabuffUpdate Update { get; set; }

}
