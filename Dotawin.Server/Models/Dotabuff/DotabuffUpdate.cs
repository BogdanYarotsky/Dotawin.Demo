namespace Dotawin.Server.Models.Dotabuff;

public class DotabuffUpdate
{
    public int Id { get; set; }
    public DateTimeOffset Date { get; set; }
    public ICollection<DotabuffHero> Heroes { get; set; } = new List<DotabuffHero>();
}
