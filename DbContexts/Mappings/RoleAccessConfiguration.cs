using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSTLifeCycleManagement.Entities;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class RoleAccessConfiguration : IEntityTypeConfiguration<RoleAccess>
    {
        public void Configure(EntityTypeBuilder<RoleAccess> builder)
        {
            builder.ToTable("RoleAccess");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.RoleName).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(200).HasColumnName("RoleName");
            builder.Property(p => p.ReadPermission).HasColumnType("bit").HasColumnName("ReadPermission");
            builder.Property(p => p.WritePermission).HasColumnType("bit").HasColumnName("WritePermission");
            builder.Property(p => p.AdminPermission).HasColumnType("bit").HasColumnName("AdminPermission");
            builder.Property(p => p.DeveloperId).HasColumnType("int").IsRequired(true).HasColumnName("DeveloperId");
            builder.HasOne<Developer>().WithMany().HasForeignKey(p => p.DeveloperId).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
