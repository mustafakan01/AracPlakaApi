using Microsoft.EntityFrameworkCore;

namespace AracKayit.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}
