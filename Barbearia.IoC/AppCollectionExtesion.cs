using Barbearia.Data.Interfaces;
using Barbearia.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Barbearia.IoC; 
public static class AppCollectionExtesion {
    public static void ConfigureAppDependecies(this IServiceCollection services, IConfiguration configuration) {
        ConfigureRepositories(services);
    }

    private static void ConfigureRepositories(IServiceCollection services) {
        services.AddScoped<IBarbeiroRepository, BarbeiroRepository>();
    }
}
