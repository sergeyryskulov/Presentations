using DependencyInjection.Interfaces;
using DependencyInjection.Services;
using DependencyInjection.Storages;
using System.Reflection;

namespace DependencyInjection.DI
{
    public static class DIExtensions
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IDatabaseStorage, DatabaseStorage>();
        }

        public static void AddMyServicesByReflection(this IServiceCollection services)
        {
            foreach (Type type in typeof(HomeService).Assembly.GetTypes().Where(t => t.Name.EndsWith("Service") && !t.IsInterface))
            {
                services.AddScoped(type);
                foreach (var typeInterface in type.GetInterfaces())
                {
                    services.AddScoped(typeInterface, type);
                }
            }

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name.EndsWith("Storage") && !t.IsInterface))
            {
                services.AddScoped(type);
                foreach (var typeInterface in type.GetInterfaces())
                {
                    services.AddScoped(typeInterface, type);
                }
            }
        }
    }
}
