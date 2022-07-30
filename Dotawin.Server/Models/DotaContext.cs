namespace Dotawin.Server.Models;
using Microsoft.EntityFrameworkCore;

public class DotaContext : DbContext
{
    public DbSet<Update> Updates { get; set; }
    public DbSet<Hero> Heroes { get; set; }
    public DbSet<Item> Items { get; set; }

    public DotaContext(DbContextOptions<DotaContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
        => builder.HasPostgresEnum<ItemType>();
}
