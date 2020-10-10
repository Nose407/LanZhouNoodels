using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouNoodels.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LanZhouNoodels
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<INoodleRepository, MockNoodleRepository>();
            services.AddTransient<IFeedBackRepository, MockFeedBackRepository>();
            //services.AddSingleton;
            //services.AddScoped;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }





            //中间件的截获“/test”
            //app.Map("/test", applicationBuilder =>
            //{
            //    applicationBuilder.Run(async context =>
            //    {
            //        await context.Response.WriteAsync("this is test");
            //    });
            //});


            //app.UseMvcWithDefaultRoute();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                //添加路由
/*                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");*/
                

            });
        }
    }
}
