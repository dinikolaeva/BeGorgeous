using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BeGorgeous.Web.Areas.Identity.IdentityHostingStartup))]

namespace BeGorgeous.Web.Areas.Identity
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
