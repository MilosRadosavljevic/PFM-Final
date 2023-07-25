using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFM.Database.Entities;

namespace PFM.Database.Configurations
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("categories");
            // primarni kljuc
            builder.HasKey(x => x.Code);
            // definisanje kolona
            builder.Property(x => x.Name).HasMaxLength(64);
            builder.Property(x => x.ParentCode);
        }
    }
}
