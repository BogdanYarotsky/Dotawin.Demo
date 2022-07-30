namespace Dotawin.Server.Models.Dota;

public class DotaPatch
{
    public int Id { get; set; }
    public string Version { get; set; } = string.Empty;
    public DateTimeOffset Date { get; set; }
    public ICollection<DotaItem> Items { get; set; } = new List<DotaItem>();
}
