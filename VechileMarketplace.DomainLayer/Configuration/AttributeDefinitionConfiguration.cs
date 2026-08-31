using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class AttributeDefinitionConfiguration : IEntityTypeConfiguration<AttributeDefinition>
    {
        public void Configure(EntityTypeBuilder<AttributeDefinition> builder)
        {
            builder.HasKey(e => e.AttributeId);
            builder.Property(e => e.AttributeId).ValueGeneratedOnAdd();

            builder.Property(e => e.AttributeDefinitionName)
                .IsRequired();

            builder.Property(e => e.AttributeDataType)
                .IsRequired();

            builder.Property(e => e.IsRequeried);
            builder.Property(e => e.IsDeleted);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder.HasOne(e => e.ProductType)
                .WithMany(pt => pt.AttributeDefinitions)
                .HasForeignKey(e => e.ProductTypeId)
                .IsRequired();
        }
    }
}
