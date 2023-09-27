using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSTLifeCycleManagement.Entities;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class AdminAccountConfiguration : IEntityTypeConfiguration<AdminAccount>
    {
        public void Configure(EntityTypeBuilder<AdminAccount> builder)
        {
            builder.ToTable("AdminAccount");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.AdminId).HasColumnType("int").IsRequired(true).HasColumnName("AdminId");
            builder.HasOne(p=>p.Admin).WithOne().HasForeignKey<AdminAccount>(p=>p.AdminId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Property(p => p.AccountName).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(100).HasColumnName("AccountName");
            builder.Property(p => p.Password).HasColumnType("nvarchar").HasMaxLength(50).IsRequired(true).HasColumnName("Password");
            builder.Property(p => p.AccountStatus).HasColumnType("nvarchar").HasMaxLength(10).IsRequired(true).HasColumnName("AccountStatus");
            builder.Ignore(p => p.AccessFailedCount);
            builder.Ignore(p => p.ConcurrencyStamp);
            builder.Ignore(p => p.Email);
            builder.Ignore(p => p.EmailConfirmed);
            builder.Ignore(p => p.LockoutEnabled);
            builder.Ignore(p => p.LockoutEnd);
            builder.Ignore(p => p.NormalizedEmail);
            builder.Ignore(p => p.NormalizedUserName);
            builder.Ignore(p => p.PasswordHash);
            builder.Ignore(p => p.PhoneNumber);
            builder.Ignore(p => p.PhoneNumberConfirmed);
            builder.Ignore(p => p.SecurityStamp);
            builder.Ignore(p => p.TwoFactorEnabled);
            builder.Ignore(p => p.UserName);
        }
    }
}
