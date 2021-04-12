using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCWithIdentity.Data;

[assembly: HostingStartup(typeof(MVCWithIdentity.Areas.Identity.IdentityHostingStartup))]
namespace MVCWithIdentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MVCWithIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MVCWithIdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MVCWithIdentityContext>();
            });
        }
    }
}