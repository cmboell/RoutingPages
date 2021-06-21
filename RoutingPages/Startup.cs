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

namespace RoutingPages
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseRouting(); //mark where routing decisions are made
            app.UseAuthorization();

            app.UseEndpoints(endpoints => //map endpoints
            {
                //uses 5 segments
                endpoints.MapControllerRoute( //custom route
                    name: "Custom",
                    pattern: "{controller}/{action}/{id}/{cat}/page{page}") ;
                //uses 4 segments
                endpoints.MapControllerRoute( //custom route
                    name: "Custom2",
                    pattern: "{controller}/{action}/{id}/{cat}");


                endpoints.MapAreaControllerRoute( //area route
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                //least specific route
                endpoints.MapControllerRoute( //default route
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                

                });
        }
    }
}
