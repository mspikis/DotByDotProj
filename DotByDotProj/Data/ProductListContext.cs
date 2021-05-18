using Microsoft.EntityFrameworkCore;
using DotByDotProj.Models;
namespace DotByDotProj.Data
{
    public class ProductListContext : DbContext
    {
        public ProductListContext(DbContextOptions<ProductListContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
