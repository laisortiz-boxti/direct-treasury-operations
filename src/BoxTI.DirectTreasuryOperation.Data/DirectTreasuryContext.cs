using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BoxTI.DirectTreasuryOperation.Data
{
    public class DirectTreasuryContext : DbContext
    {
        public DirectTreasuryContext(DbContextOptions<DirectTreasuryContext> options) : base(options) 
        { }

        public DbSet<DirectTreasuryOperations> Operations { get; set; }
        public DbSet<OperationAmount> OperationsAmount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
            );
        }
    }
}
