using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
        {
            builder.HasKey(e => e.PavId);
            builder.Property(e => e.PavId).ValueGeneratedOnAdd();

            builder.Property(e => e.Values);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder.HasOne(e => e.Product)
                .WithMany(p => p.ProductAttributeValues)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();

            builder.HasOne(e => e.AttributeDefinition)
                .WithMany(ad => ad.ProductAttributeValues)
                .HasForeignKey(e => e.AttributeId)
                .IsRequired();
        }
    }
}
