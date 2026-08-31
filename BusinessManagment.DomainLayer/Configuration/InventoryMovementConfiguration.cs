using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class InventoryMovementConfiguration : IEntityTypeConfiguration<InventoryMovement>
    {
        public void Configure(EntityTypeBuilder<InventoryMovement> builder)
        {

            builder.HasKey(e => e.InventoryMovementId);
            builder.Property(e => e.InventoryMovementId).ValueGeneratedOnAdd();

            builder.Property(e => e.QuantityChange);
            builder.Property(e => e.Reason);
            builder.Property(e => e.Remark);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder.HasOne(e => e.Inventory)
                .WithMany(i => i.InventoryMovements)    
                .HasForeignKey(e => e.InventoryId)
                .IsRequired();
        }
    }
}
