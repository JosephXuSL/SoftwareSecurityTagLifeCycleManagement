using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSTLifeCycleManagement.Entities;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class SecurityTagConfiguration : IEntityTypeConfiguration<SecurityTag>
    {
        public void Configure(EntityTypeBuilder<SecurityTag> builder)
        {
            builder.ToTable("SecurityTag");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.AppId).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(20).HasColumnName("AppId");
            builder.Property(p => p.AppName).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasColumnName("AppName");
            builder.Property(p => p.Version).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(20).HasColumnName("Version");
            builder.Property(p => p.Memory).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(20).HasColumnName("Memory");
            builder.Property(p => p.DeveloperId).HasColumnType("int").IsRequired(true).HasColumnName("DeveloperId");
            builder.HasOne(p => p.Developer).WithMany().HasForeignKey(p => p.DeveloperId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Property(p => p.DevelopTime).HasColumnType("datetime").IsRequired(true).HasColumnName("DevelopTime");
            builder.Property(p => p.Signature).HasColumnType("nvarchar").HasColumnName("Signature");
            builder.Property(p => p.MaxUsers).HasColumnType("int").HasColumnName("MaxUsers");
            builder.Property(p => p.Status).HasColumnType("nvarchar").HasMaxLength(10).HasColumnName("Status");
            builder.Property(p => p.CreateTime).HasColumnType("datetime").IsRequired(true).HasColumnName("CreateTime");
        }
    }
}
