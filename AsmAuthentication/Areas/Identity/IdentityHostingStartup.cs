using System;
using AsmAuthentication.Areas.Identity.Data;
using AsmAuthentication.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AsmAuthentication.Areas.Identity.IdentityHostingStartup))]
namespace AsmAuthentication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AsmAuthenticationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AsmAuthenticationContextConnection")));

                services.AddDefaultIdentity<AsmAuthenticationUser>()
                    .AddEntityFrameworkStores<AsmAuthenticationContext>();
            });
        }
    }
}