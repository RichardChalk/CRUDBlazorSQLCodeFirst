using Microsoft.EntityFrameworkCore;

namespace CRUDCodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Champion> Champions { get; set; }
    }
}
