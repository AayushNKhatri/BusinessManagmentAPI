using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(e => e.OrderItemId);
            builder.Property(e => e.OrderItemId).ValueGeneratedOnAdd();

            builder.Property(e => e.Quantity).IsRequired();
            builder.Property(e => e.SellingPrice).HasColumnType("money").IsRequired();
            builder.Property(e => e.Discount).HasColumnType("money");
            builder.Property(e => e.Subtotal).HasColumnType("money").IsRequired();
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);

            builder.HasOne(e => e.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(e => e.OrderId)
                .IsRequired();

            builder.HasOne(e => e.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();
        }
    }
}
