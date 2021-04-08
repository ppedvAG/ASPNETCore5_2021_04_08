using DI_BasicSample;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverviewMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //MVC ab 3.0/3.1 
            services.AddControllersWithViews(); // Webseite (Contents) laufen auf MVC


            services.AddTransient<ICar, MockCar>(); //wird dieses ausgegeben
            services.AddSingleton<ICar, Car>();
           
            services.AddSingleton<MockCar>(); // 
            //services.AddScoped<ICar, Car>();



            //services.AddSingleton(typeof(ICar), nameof(Car));

            /* services.AddRazorPages();*/ //Administrative für User Management läuft Razor Pages 
                                           //Konvention -> Verzeichnis (Controller/Views) müssen im Projekt vorhanden sein, bzw angelegt werden
                                           //services.AddMvc(); Vor 3.0 wurde AddMVC verwendet

            /*services.AddControllers();*/ //WebAPI -> Benötige Controller-Verzeichnis 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
