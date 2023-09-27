using SSTLifeCycleManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasColumnName("Name");
            builder.Property(p => p.IdentityCardNumber).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(18).HasColumnName("IdentityCardNumber");
            builder.Property(p => p.UserStatus).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(10).HasColumnName("UserStatus");
            builder.Property(p => p.Gen).HasColumnType("nvarchar").HasMaxLength(10).IsRequired(true).HasColumnName("Gen");
            builder.Property(p => p.PhoneNumber).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(20).HasColumnName("PhoneNumber");
            builder.Property(p => p.Email).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(50).HasColumnName("Email");
            builder.Property(p => p.DeveloperId).HasColumnType("int").HasColumnName("DeveloperId");
            builder.HasOne(p=>p.Developer).WithMany().HasForeignKey(p => p.DeveloperId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
