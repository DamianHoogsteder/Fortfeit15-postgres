using Forfeit15.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace Forfeit15.Postgres.Contexts;

public class UserMetaDataDbContext : DbContext
{
    public virtual DbSet<UserMetaData> UserMetaData { get; set; } = null!;

    public UserMetaDataDbContext()
    {
    }

    public UserMetaDataDbContext(DbContextOptions<UserMetaDataDbContext> options)
        : base(options)
    {
    }
}