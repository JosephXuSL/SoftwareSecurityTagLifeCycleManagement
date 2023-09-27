using SSTLifeCycleManagement.DbContexts.Mappings;
using SSTLifeCycleManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace SSTLifeCycleManagement.DbContexts
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<AdminAccount> AdminAccount { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Developer> Developer { get; set; }
        public DbSet<RoleAccess> RoleAccess { get; set; }
        public DbSet<SecurityTag> SecurityTag { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountriesConfiguration());
            modelBuilder.ApplyConfiguration(new PeopleConfiguration());
            modelBuilder.ApplyConfiguration(new AdminAccountConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new DeveloperConfiguration());
            modelBuilder.ApplyConfiguration(new RoleAccessConfiguration());
            modelBuilder.ApplyConfiguration(new SecurityTagConfiguration());
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
