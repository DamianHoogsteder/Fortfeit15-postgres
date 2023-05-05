using Forfeit15.Postgres.Contexts;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Forfeit15.Postgres.Extensions;

[UsedImplicitly]
public static class ServiceCollectionExtension
{
    /// <summary>
    /// Voegt generieke Postgres verbinding, voor Patch notes toe.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddPatchNotePostgres(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(nameof(PatchNoteDbContext));
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
        var dataSource = dataSourceBuilder.Build();
        services.AddDbContext<PatchNoteDbContext>(options => options.UseNpgsql(dataSource));
        return services;
    }
    
    /// <summary>
    /// Voegt generieke Postgres verbinding, voor Preferences toe.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddPreferencesPostgres(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(nameof(PreferenceDbContext));
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
        var dataSource = dataSourceBuilder.Build();
        services.AddDbContext<PreferenceDbContext>(options => options.UseNpgsql(dataSource));
        return services;
    }
}