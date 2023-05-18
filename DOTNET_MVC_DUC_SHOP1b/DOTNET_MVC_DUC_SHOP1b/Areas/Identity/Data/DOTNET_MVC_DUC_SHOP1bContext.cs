using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_MVC_DUC_SHOP1b.Data
{
    public class DOTNET_MVC_DUC_SHOP1bContext : IdentityDbContext<IdentityUser>
    {
        public DOTNET_MVC_DUC_SHOP1bContext(DbContextOptions<DOTNET_MVC_DUC_SHOP1bContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
