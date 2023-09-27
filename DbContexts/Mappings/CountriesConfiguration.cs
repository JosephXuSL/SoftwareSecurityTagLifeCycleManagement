using SSTLifeCycleManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SSTLifeCycleManagement.DbContexts.Mappings
{
    public class CountriesConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("int").HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(p => p.CountryName).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasColumnName("CountryName");
            
            builder.Property(p => p.CountryCode).HasColumnType("nvarchar").HasMaxLength(10).IsRequired(true).HasColumnName("CountryCd");                        
        }
    }
}
