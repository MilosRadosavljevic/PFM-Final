using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFM.Database.Entities;

namespace PFM.Database.Configurations
{
    public class TransactionEntityTypeConfiguration : IEntityTypeConfiguration<TransactionEntity>
    {
        public void Configure(EntityTypeBuilder<TransactionEntity> builder)
        {
            builder.ToTable("transactions");
            // primarni kljuc
            builder.HasKey(x => x.Id);
            // definisanje kolona
            builder.Property(x => x.BeneficiaryName).HasMaxLength(64);
            builder.Property(x => x.Date);
            builder.Property(x => x.Direction).HasConversion<string>().IsRequired();
            builder.Property(x => x.Amount);
            builder.Property(x => x.Description).HasMaxLength(1024);
            builder.Property(x => x.Currency).IsRequired();
            builder.Property(x => x.MccCode)
                .HasConversion<int?>();
            builder.Property(x => x.Kind).HasConversion<string>();

            builder.HasOne(x => x.Category)
             .WithMany()
             .HasForeignKey(x => x.catCode)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
