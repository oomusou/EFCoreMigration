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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var customerID = 1;
            
            modelBuilder.Entity<Customer>().HasData(new Customer {
                CustomerID = customerID++,
                Name = "Sam",
                Age = 18,
            });
            
            modelBuilder.Entity<Customer>().HasData(new Customer {
                CustomerID = customerID++,
                Name = "Kevin",
                Age = 19,
            });
        }
    }
}