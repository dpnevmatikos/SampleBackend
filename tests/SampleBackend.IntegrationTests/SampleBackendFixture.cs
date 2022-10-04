namespace Atlas.Domain.Tests
{
    using System;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// 
    /// </summary>
    public class SampleBackendTestsFixture : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        private IServiceScope scope_;

        /// <summary>
        /// 
        /// </summary>
        public IServiceProvider Provider { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public SampleBackendTestsFixture()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath($"{AppDomain.CurrentDomain.BaseDirectory}")
                .AddJsonFile("appsettings.json", false)
                .Build();

            var sc = new ServiceCollection();

            scope_ = sc.BuildServiceProvider().CreateScope();
            Provider = scope_.ServiceProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            scope_.Dispose();
        }
    }
}