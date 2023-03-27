using Forfeit15.Postgres.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;

namespace Forfeit15.Postgres.Support;

public class PatchNoteDesignTimeDbContextFactory : IDesignTimeDbContextFactory<PatchNoteDbContext>
{
    private const string ConnectionString = "Host=localhost;Database=patchnotes;Username=postgres;password=Welkom12345";
    public PatchNoteDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PatchNoteDbContext>();
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectionString);
        using var dataSource = dataSourceBuilder.Build();
        optionsBuilder.UseNpgsql(dataSource);
        return new PatchNoteDbContext(optionsBuilder.Options);
    }
}