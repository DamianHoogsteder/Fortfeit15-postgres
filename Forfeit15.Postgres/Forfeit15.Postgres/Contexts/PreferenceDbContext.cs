using Forfeit15.Postgres.Models.Preferences;
using Microsoft.EntityFrameworkCore;

namespace Forfeit15.Postgres.Contexts;

public class PreferenceDbContext : DbContext
{
    public virtual DbSet<Preference> Preferences { get; set; } = null!;

    public PreferenceDbContext()
    {
    }

    public PreferenceDbContext(DbContextOptions<PreferenceDbContext> options) : base(options)
    {
    }
}