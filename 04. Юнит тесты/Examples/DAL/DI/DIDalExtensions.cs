using DAL.Interfaces;
using DAL.Storages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DI
{
    public static class DIDalExtensions
    {      
        public static void AddDal(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseStorage, DatabaseStorage>();                
        }

    }
}
