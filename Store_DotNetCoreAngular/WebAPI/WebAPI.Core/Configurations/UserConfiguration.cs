using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Core.Models;

namespace WebAPI.Core.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserApplication>
    {
        public void Configure(EntityTypeBuilder<UserApplication> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.UserName).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(255);
        }
    }
}
