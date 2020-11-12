using Microsoft.EntityFrameworkCore;

namespace HRM.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext>options) : base(options)
        {

        }
        public DbSet <Employee> Employees { get; set; }
    }
}
