using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Server
{
    public class Program
    {
        const int a = 5;
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    string port = System.Environment.GetEnvironmentVariable("PORT");
                    if (port != null)
                    {
                        webBuilder.UseStartup<Startup>().UseUrls($"http://*:{port}");
                    }
                    else 
                    {
                        webBuilder.UseStartup<Startup>();   
                    }
                    
                }); 
    }
}