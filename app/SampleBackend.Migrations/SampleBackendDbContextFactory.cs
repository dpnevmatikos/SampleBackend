using SampleBackend.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;

namespace SampleBackend.Migrations
{
    public class SampleBackendDbContextFactory : IDesignTimeDbContextFactory<SampleBackendDbContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public SampleBackendDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath($"{AppDomain.CurrentDomain.BaseDirectory}")
                .AddJsonFile("appsettings.json", false)
                .Build();

            var connString = configuration.GetRequiredSection("Database").Value;

            var optionsBuilder = new DbContextOptionsBuilder<SampleBackendDbContext>();

            optionsBuilder.UseSqlServer(
                connString,
                options => {
                    options.MigrationsAssembly("SampleBackend.Migrations");
                });

            return new SampleBackendDbContext(optionsBuilder.Options);
        }
    }
}
