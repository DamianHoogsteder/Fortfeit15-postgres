using Forfeit15.Postgres.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;

namespace Forfeit15.Postgres.Support;

public class UserMetaDataDesignTimeDbContextFactory : IDesignTimeDbContextFactory<UserMetaDataDbContext>
{
    private const string ConnectionString = "Host=localhost;Database=usermetadata;Username=postgres;password=Welkom12345";
    public UserMetaDataDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<UserMetaDataDbContext>();
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectionString);
        using var dataSource = dataSourceBuilder.Build();
        optionsBuilder.UseNpgsql(dataSource);
        return new UserMetaDataDbContext(optionsBuilder.Options);
    }
}