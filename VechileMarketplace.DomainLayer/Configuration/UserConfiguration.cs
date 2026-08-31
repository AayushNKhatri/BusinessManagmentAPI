using BusinessManagment.DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessManagment.DomainLayer.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {

            // Custom fields
            builder.Property(e => e.IsActive);
            builder.Property(e => e.IsDeleted);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);
        }
    }
}
