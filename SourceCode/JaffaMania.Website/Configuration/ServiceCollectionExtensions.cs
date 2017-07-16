using JaffaMania.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JaffaMania.Website.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccessLayerWithEfCore(
            this IServiceCollection services, IConfigurationRoot configuration)
        {
            // services.AddTransient<IAuthorisationFileRepository, EfCodeFirstAuthorisationFileRepository>();

            services.AddDbContext<JafamaniaDbContext>(cfg => cfg.UseSqlServer(
                configuration.GetConnectionString("LocalConnection"),
                m => m.MigrationsAssembly("JaffaMania.Data")));

            return services;
        }
    }
}