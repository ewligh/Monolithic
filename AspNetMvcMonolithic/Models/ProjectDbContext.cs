using AspNetMvcMonolithic.Models.DomainModels.PersonAggregates;
using AspNetMvcMonolithic.Models.DomainModels.ProductAggregates;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcMonolithic.Models
{
    public class ProjectDbContext : DbContext
    {

        // سازنده کلاس ApplicationDbContext
        public ProjectDbContext(
            DbContextOptions<ProjectDbContext> options
        ) : base(options)
        {
            // تنظیمات اتصال به دیتابیس به کلاس پایه DbContext ارسال می‌شود
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }


    }
}
