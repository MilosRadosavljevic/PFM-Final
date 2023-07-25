using Microsoft.EntityFrameworkCore;
using PFM.Database.Configurations;
using PFM.Database.Entities;

namespace PFM.Database
{
    public class PfmDbContext : DbContext
    {
        public DbSet<TransactionEntity> Transactions { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<TransactionSplitEntity> TransactionSplits { get; set; }

        public PfmDbContext(DbContextOptions options) : base(options)
        {
        }

        public PfmDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            modelBuilder.ApplyConfiguration(
                new TransactionEntityTypeConfiguration()
                );
            modelBuilder.ApplyConfiguration(
                new CategoryEntityTypeConfiguration()
                );
            modelBuilder.ApplyConfiguration(
                new TransactionSplitEntityConfiguration()
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
