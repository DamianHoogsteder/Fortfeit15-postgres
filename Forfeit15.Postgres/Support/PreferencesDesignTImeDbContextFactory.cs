using Forfeit15.Postgres.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;

namespace Forfeit15.Postgres.Support;

public class PreferencesDesignTimeDbContextFactory : IDesignTimeDbContextFactory<PreferenceDbContext>
{
    private const string ConnectionString = "Host=localhost;Database=preferences;Username=postgres;password=Welkom12345";
    public PreferenceDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PreferenceDbContext>();
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectionString);
        using var dataSource = dataSourceBuilder.Build();
        optionsBuilder.UseNpgsql(dataSource);
        return new PreferenceDbContext(optionsBuilder.Options);
    }
}