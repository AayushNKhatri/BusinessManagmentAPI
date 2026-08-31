using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class OrderHistoryConfiguration : IEntityTypeConfiguration<OrderHistory>
    {
        public void Configure(EntityTypeBuilder<OrderHistory> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Status);
            builder.Property(e => e.ChangedAt);
            builder.Property(e => e.Remark);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);
        }
    }
}
