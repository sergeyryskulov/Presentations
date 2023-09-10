

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example6.Repository;
using Example6.Services;


namespace CFT.Template
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {


            foreach (Type type in typeof(TestRepository).Assembly.GetTypes().Where(t => t.Name.EndsWith("Repository") && !t.IsInterface))
            {
                services.AddScoped(type);
                foreach (var typeInterface in type.GetInterfaces())
                {
                    services.AddScoped(typeInterface, type);
                }
            }

            foreach (Type type in typeof(HomeService).Assembly.GetTypes().Where(t => t.Name.EndsWith("Service") && !t.IsInterface))
            {
                services.AddScoped(type);
                foreach (var typeInterface in type.GetInterfaces())
                {
                    services.AddScoped(typeInterface, type);
                }
            }


            services.AddHttpContextAccessor();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //переменная среды ASPNETCORE_ENVIRONMENT
            //env.EnvironmentName = EnvironmentName.Staging;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else if (env.IsProduction() || env.IsStaging())
            {
                app.UseExceptionHandler("/Error/ErrorStatus/500");
                
            }

            //указываем что сайт работает только по протоколу HTTPS, через заголовок
            //также надо указать в настройках проекта что сайт работает через SSL
            app.UseHsts();

            app.UseHttpsRedirection();

            //в принципе тоже самое, что и через конфиг
            app.UseStatusCodePagesWithReExecute("/Error/ErrorStatus/{0}");

            //Использование статических файлов из папки root
            app.UseStaticFiles();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
