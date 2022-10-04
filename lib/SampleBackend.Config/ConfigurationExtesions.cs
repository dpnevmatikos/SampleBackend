using Microsoft.Extensions.Configuration;

namespace SampleBackend.Config
{
    public static class ConfigurationExtesions
    {
        public static SampleBackendAppConfig ReadAppConfiguration(
            this IConfiguration @this)
        {
            var connString = @this.GetRequiredSection("Database").Value;

            return new SampleBackendAppConfig()
            {
                DatabaseConnectionString = connString
            };
        }
    }
}
