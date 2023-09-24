using DependencyInjection.Services;
using System.Reflection;

namespace DependencyInjection.DI
{
    public static class DIExtensions
    {
        public static void AddMyServices(this IServiceCollection services)
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
