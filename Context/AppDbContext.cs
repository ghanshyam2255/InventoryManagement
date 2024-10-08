using InventoryManagement.Models;                                                                                   
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}
