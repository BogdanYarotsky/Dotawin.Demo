namespace Dotawin.Server.Models;

public class Update
{
    public int Id { get; set; }
    public DateTimeOffset DateTime { get; set; }
    public ICollection<Hero> Heroes { get; set; } = new List<Hero>();
}
