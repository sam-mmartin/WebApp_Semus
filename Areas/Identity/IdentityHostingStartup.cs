using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebApp_Semus.Areas.Identity.IdentityHostingStartup))]
namespace WebApp_Semus.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}