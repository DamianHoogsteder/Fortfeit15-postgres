using Forfeit15.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace Forfeit15.Postgres.Contexts;

public class PatchNoteDbContext : DbContext
{
    //Tables
    public virtual DbSet<PatchNote> PatchNotes { get; set; } = null!;

    public PatchNoteDbContext()
    {
    }

    public PatchNoteDbContext(DbContextOptions<PatchNoteDbContext> options) : base(options)
    {
    }
}