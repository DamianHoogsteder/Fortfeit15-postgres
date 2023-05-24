using Forfeit15.Postgres.Models;
using Forfeit15.Postgres.Models.Nodes;
using Microsoft.EntityFrameworkCore;

namespace Forfeit15.Postgres.Contexts;

public class PatchNoteDbContext : DbContext
{
    public virtual DbSet<PatchNote> PatchNotes { get; set; } = null!;
    public virtual DbSet<InfoNode> InfoNodes { get; set; } = null!;

    public PatchNoteDbContext()
    {
    }
    
    public PatchNoteDbContext(DbContextOptions<PatchNoteDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InfoNode>()
            .ToTable("InfoNodes")
            .HasDiscriminator<string>("NodeType")
            .HasValue<TextNode>("Text")
            .HasValue<ImageNode>("Image");

        modelBuilder.Entity<PatchNote>()
            .HasMany(p => p.InfoNodes)
            .WithOne()
            .HasForeignKey(n => n.Id);
    }
}