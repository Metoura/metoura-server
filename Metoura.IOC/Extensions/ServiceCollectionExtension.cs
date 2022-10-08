using Metoura.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Metoura.IOC.Extensions
{

    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
        {
            
            var serverVersion = new MySqlServerVersion(new Version(5, 5, 62));
            services.AddDbContext<MetouraRWContext>(options =>
                options.UseMySql(connectionString, serverVersion));
            return services;
        }
    }

    // public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
    // {
    //     public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
    //     {
    //         serviceCollection.AddEntityFrameworkMySQL();
    //         new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection)
    //             .TryAddCoreServices();
    //     }
    // }
}