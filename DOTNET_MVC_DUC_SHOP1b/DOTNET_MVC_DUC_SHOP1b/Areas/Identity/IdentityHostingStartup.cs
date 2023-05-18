using System;
using DOTNET_MVC_DUC_SHOP1b.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DOTNET_MVC_DUC_SHOP1b.Areas.Identity.IdentityHostingStartup))]
namespace DOTNET_MVC_DUC_SHOP1b.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DOTNET_MVC_DUC_SHOP1bContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DOTNET_MVC_DUC_SHOP1bContextConnection")));

                
            });
        }
    }
}