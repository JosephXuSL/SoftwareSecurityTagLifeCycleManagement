using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSTLifeCycleManagement.Entities;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRole");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.UserId).HasColumnType("int").IsRequired(true).HasColumnName("UserId");
            builder.HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Property(p => p.RoleId).HasColumnType("int").IsRequired(true).HasColumnName("RoleId");
            builder.HasOne(p => p.Role).WithMany().HasForeignKey(p => p.RoleId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Property(p => p.TagId).HasColumnType("int").HasColumnName("SecurityTagId");
            builder.HasOne(p => p.APPSecurityTag).WithMany().HasForeignKey(p => p.TagId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
