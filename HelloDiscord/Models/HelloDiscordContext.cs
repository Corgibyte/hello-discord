using Microsoft.EntityFrameworkCore;

namespace HelloDiscord.Models
{
  public class HelloDiscordContext : DbContext
  {
    public DbSet<Event> Events { get; set; }

    public HelloDiscordContext(DbContextOptions options) : base(options) { }
  }
}