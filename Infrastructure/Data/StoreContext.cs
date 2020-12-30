using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
    }
}