using DALLayer.Interfaces;
using DALLayer.Storages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer.DI
{
    public static class DIDalExtensions
    {
        public static void AddDal(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseStorage, DatabaseStorage>();
        }

    }
}
