using Chapter_14_DefiningClasses.Problem20;
using Chapter_14_DefiningClasses.Problem23;
using Microsoft.Extensions.DependencyInjection;
using System;
using Utilities;

namespace Chapter_14_DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Problem problem20 = new Problem_20();
            // problem20.Run();

            IServiceProvider provider = ConfigureServices();
            Problem problem23 = new Problem_23(provider);
            problem23.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<GenericList<string>>(new GenericList<string>());

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
