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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Diagnostics;

namespace LanZhouNoodels
{
    public class Startup
    {
        public IConfiguration Configuaration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuaration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options =>
            {
                options.UseSqlServer(Configuaration.GetConnectionString("DefaultConnection"));
            });
            /*            services.AddDbContext<AppDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                        );*/
            services.AddMvc();
            services.AddTransient<INoodleRepository, NoodleRepository>();
            services.AddTransient<IFeedBackRepository, FeedBackRepository>();
            //services.AddTransient<INoodleRepository, MockNoodleRepository>();
            //services.AddTransient<IFeedBackRepository, MockFeedBackRepository>();
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {


                //添加路由
                endpoints.MapDefaultControllerRoute();
   /*             endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );*/
                endpoints.MapRazorPages();
                /*                endpoints.MapGet("/", async context =>
                                {
                                    await context.Response.WriteAsync("Hello World!");
                                });*/

            });
        }
    }
}
