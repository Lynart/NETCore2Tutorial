using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core2._1Tutorial
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDefaultFiles();
            // Serves files (otherwise trying to access index.html won't work)
            app.UseStaticFiles();
            app.UseNodeModules(env);
            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Foo", 
                    "/users/manage", 
                    new { controller = "UserManagement", Action = "Index" });
            });
                
        }
    }
}
