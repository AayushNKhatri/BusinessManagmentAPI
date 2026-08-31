using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(e => e.ProductTypeId);
            builder.Property(e => e.ProductTypeId).ValueGeneratedOnAdd();

            builder.Property(e => e.ProductTypeName).IsRequired();
            builder.Property(e => e.Description).HasColumnType("TEXT");
            builder.Property(e => e.IsDeleted);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);
        }       
    }
}
