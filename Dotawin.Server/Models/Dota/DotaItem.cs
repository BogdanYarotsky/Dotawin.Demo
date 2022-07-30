namespace Dotawin.Server.Models.Dota;

public class DotaItem
{
    public int Id { get; set; }
    public int GameId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string InternalName { get; set; } = string.Empty;
    public int Cost { get; set; }
}
