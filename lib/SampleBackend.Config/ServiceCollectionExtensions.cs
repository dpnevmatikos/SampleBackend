using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SampleBackend.Config
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfig(
            this IServiceCollection @this)
        {
            return @this.AddSingleton<SampleBackendAppConfig>(
                (serviceProvider) => {
                    var configuration = serviceProvider.GetRequiredService<IConfiguration>();

                    return configuration.ReadAppConfiguration();
                });
        }
    }
}
