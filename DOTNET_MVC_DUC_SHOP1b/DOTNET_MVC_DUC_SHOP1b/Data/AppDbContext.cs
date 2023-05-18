using Microsoft.EntityFrameworkCore;

namespace DOTNET_MVC_DUC_SHOP1b.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {
        }
        public DbSet<DOTNET_MVC_DUC_SHOP1b.Models.Product> Products { get; set; }

    }
}
