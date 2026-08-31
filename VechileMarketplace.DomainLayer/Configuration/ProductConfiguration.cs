using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.ProductId);
            builder.Property(e => e.ProductId).ValueGeneratedOnAdd();

            builder.Property(e => e.ProductName).IsRequired();
            builder.Property(e => e.ProductDescription).HasColumnType("TEXT");
            builder.Property(e => e.IsActive);
            builder.Property(e => e.IsDeleted);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder.HasOne(e => e.ProductType)
                .WithMany(pt => pt.Products)
                .HasForeignKey(e => e.ProductTypeId)
                .IsRequired();
        }
    }
}
