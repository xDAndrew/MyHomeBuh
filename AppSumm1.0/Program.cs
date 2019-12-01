// 1. Написать API метод в Home контроллере, который называется GetSumm и возвращает текущую сумму на счету
// 2. Написать API метод в Home контроллере, который называется GetStatistic и возвращает сумму платежей и сумму пополнений
// 3. Написать API метод в Home контроллере, который возвращает разность платежей и пополнений
// 4. Пункты 2 и 3 выводят статистику только за текущий месяц (DateTime.Now.Month)
// 5. Сделать Pull Request
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
