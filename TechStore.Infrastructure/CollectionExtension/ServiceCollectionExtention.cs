using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechStore.Infrastructure.DataBase;

namespace TechStore.Infrastructure.CollectionExtension;

public static class ServiceCollectionExtention
{




    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TechStoreDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("TechStore")));

        return services;
    }
}
