using SSTLifeCycleManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class PeopleConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.ToTable("People");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired(true).HasColumnName("Name");
            builder.Property(p => p.CountryCd).HasColumnType("nvarchar").HasMaxLength(10).IsRequired(true).HasColumnName("Country");
            builder.Property(p => p.PhoneNumber).HasColumnType("nvarchar").HasMaxLength(20).IsRequired(false).HasColumnName("PhoneNumber");
            builder.HasOne(p => p.Country).WithMany().HasForeignKey(k => k.CountryCd).HasPrincipalKey(k=>k.CountryCode).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
