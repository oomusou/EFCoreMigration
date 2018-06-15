using Microsoft.EntityFrameworkCore;

namespace EFCoreMigration
{
    public class EFLabDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        private const string DbConnectionString = "Host=localhost;Port=5432;Database=eflab;Username=admin;Password=12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DbConnectionString);
        }
    }
}