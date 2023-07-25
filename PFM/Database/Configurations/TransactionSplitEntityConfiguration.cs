using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFM.Database.Entities;

namespace PFM.Database.Configurations
{
    public class TransactionSplitEntityConfiguration : IEntityTypeConfiguration<TransactionSplitEntity>
    {
        public void Configure(EntityTypeBuilder<TransactionSplitEntity> builder)
        {
            builder.ToTable("transaction-splits");
            // strani kljucevi
            //builder.HasNoKey();
            builder.HasKey(ts => new { ts.TransactionId, ts.CategoryCode });
            // definisanje kolona
            builder.Property(x => x.TransactionId);
            builder.Property(x => x.CategoryCode);
            builder.Property(x => x.Amount);

            builder.HasOne(x => x.Transaction)
                   .WithMany(t => t.Splits)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Category)
                   .WithMany(t => t.Splits)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
