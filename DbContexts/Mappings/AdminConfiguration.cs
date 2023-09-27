using SSTLifeCycleManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admin");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasColumnName("Name");
            builder.Property(p => p.JobNumber).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasColumnName("JobNumber");
            builder.Property(p => p.EmployeeStatus).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(20).HasColumnName("EmployeeStatus");
            builder.Property(p => p.Gen).HasColumnType("nvarchar").HasMaxLength(10).IsRequired(true).HasColumnName("Gen");
            builder.Property(p => p.PhoneNumber).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(20).HasColumnName("PhoneNumber");
            builder.Property(p => p.Birthday).HasColumnType("date").HasColumnName("Birthday");
        }
    }
}
