using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSTLifeCycleManagement.Entities;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.ToTable("Developer");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(200).HasColumnName("Name");
            builder.Property(p => p.Address).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(1000).HasColumnName("Address");
            builder.Property(p => p.Description).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(2000).HasColumnName("Description");
            builder.Property(p => p.BusinessCertificate).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(500).HasColumnName("BusinessCertificate");
            builder.Property(p => p.Status).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(20).HasColumnName("Status");
        }
    }
}
