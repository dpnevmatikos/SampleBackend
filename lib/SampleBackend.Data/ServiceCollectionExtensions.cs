using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using SampleBackend.Config;

namespace SampleBackend.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSampleBackendDbContext(
            this IServiceCollection @this)
        {
            return @this.AddDbContext<SampleBackendDbContext>(
                (serviceProvider, options) =>
                {
                    var config = serviceProvider.GetRequiredService<SampleBackendAppConfig>();

                    options.UseSqlServer(config.DatabaseConnectionString);
                });
        }
    }
}
