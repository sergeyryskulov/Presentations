using Application.Interfaces;
using Application.Services;
using DAL.DI;
using System.Reflection;

namespace Application.DI
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
