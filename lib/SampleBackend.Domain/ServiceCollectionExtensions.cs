using Microsoft.Extensions.DependencyInjection;

namespace SampleBackend.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(
            this IServiceCollection @this)
        {
            @this.AddScoped<ICustomerService, CustomerService>();

            return @this;
        }
    }
}
