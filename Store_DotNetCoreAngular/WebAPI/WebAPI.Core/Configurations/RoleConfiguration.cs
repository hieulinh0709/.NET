using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Core.Models;

namespace WebAPI.Core.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<RoleApplication>
    {
        public void Configure(EntityTypeBuilder<RoleApplication> builder)
        {
            builder.ToTable("Roles");
            builder.Property(x => x.Description).HasMaxLength(255).IsRequired();
        }
    }
}
