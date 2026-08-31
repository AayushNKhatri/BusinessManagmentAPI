using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {

            builder.HasKey(e => e.InventoryId);
            builder.Property(e => e.InventoryId).ValueGeneratedOnAdd();

            builder.Property(e => e.PurchasePrice);
            builder.Property(e => e.SellingPrice);
            builder.Property(e => e.SellableStock);
            builder.Property(e => e.DamagedStock);
            builder.Property(e => e.IsDeleted);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder.HasOne(e => e.Product)
                .WithOne(p => p.Inventory)
                .HasForeignKey<Inventory>(e => e.ProductId)
                .IsRequired(false);
        }
    }
}
