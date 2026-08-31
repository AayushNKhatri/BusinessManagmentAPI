using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasKey(e => e.OrderId);
            builder.Property(e => e.OrderId).ValueGeneratedOnAdd();

            builder.Property(e => e.CustomerName).IsRequired();
            builder.Property(e => e.Phone).HasMaxLength(15).IsRequired();
            builder.Property(e => e.Address).IsRequired();
            builder.Property(e => e.Status);
            builder.Property(e => e.PaymentStatus);
            builder.Property(e => e.TotalAmt).HasColumnType("money").IsRequired();
            builder.Property(e => e.Remark);
            builder.Property(e => e.IsDeleted);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);
        }
    }
}
