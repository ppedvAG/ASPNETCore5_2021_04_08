using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCWithIdentityUISample.Areas.Identity.Data;
using MVCWithIdentityUISample.Data;

[assembly: HostingStartup(typeof(MVCWithIdentityUISample.Areas.Identity.IdentityHostingStartup))]
namespace MVCWithIdentityUISample.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MVCWithIdentityUISampleContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MVCWithIdentityUISampleContextConnection")));

                services.AddDefaultIdentity<MVCWithIdentityUISampleUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MVCWithIdentityUISampleContext>();
            });
        }
    }
}