using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BoxTI.DirectTreasuryOperation.Data
{
    public class DirectTreasuryContext : DbContext
    {
        public DbSet<DirectTreasuryOperations> DirectTreasuryOperations { get; set; }
        public DbSet<OperationsAmount> OperationsAmount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;user=user;password=password;database=db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
            );
        }
    }
}
