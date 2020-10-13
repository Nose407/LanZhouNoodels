using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanZhouNoodleCJ.Modles;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LanZhouNoodleCJ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope()) {
                var servers = scope.ServiceProvider;
                try
                {
                    var context = servers.GetRequiredService<AppDbContext>();
                    DBIntiallzer.IntiNoodles(context);
                }
                catch (Exception)
                {
                    //故意留空，以后可以添加日志
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
