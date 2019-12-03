using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System.Net;

namespace AppSumm1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWebHost(args).Build().Run();
        }
        public static IHostBuilder CreateWebHost(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webhost =>
                {
                    webhost
                    .UseStartup<Startup>()
                    .UseKestrel((hostBuilderContext, options) =>
                    {
                        options.Listen(IPAddress.Any, 5000);
                    });
                });
        }
    }
}
