using ApplicationLayer.Interfaces;
using ApplicationLayer.Services;

using System.Reflection;
using DALLayer.DI;

namespace ApplicationLayer.DI
{
    public static class DIExtensions
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddScoped<IHomeService, HomeService>();

            services.AddDal();
        }
    }
}
