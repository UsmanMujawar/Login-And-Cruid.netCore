using Microsoft.EntityFrameworkCore;

namespace WebApplication179.Models
{
    public class BrandContext:DbContext

    {
        public BrandContext(DbContextOptions<BrandContext> options):base(options)   
        {


        }

        public DbSet<Brand> Brands { get; set; }

    }
}
