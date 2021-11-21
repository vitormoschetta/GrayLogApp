using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Gelf.Extensions.Logging;

namespace GrayLogApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .ConfigureLogging((context, builder) => builder.AddGelf(options =>
                    {
                        options.LogSource = context.HostingEnvironment.ApplicationName;                        
                    }));
                });
    }
}
