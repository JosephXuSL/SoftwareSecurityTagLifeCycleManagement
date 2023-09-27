using SSTLifeCycleManagement.DbContexts;
using SSTLifeCycleManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Azure.Core;
using SSTLifeCycleManagement.Models;
using AutoMapper;

namespace SSTLifeCycleManagement.Repositories
{
    public class DataRepository
    {
        protected MainDbContext _dbcontext;
        private readonly ILogger<DataRepository> _logger;
        private readonly IMapper _mapper;

        public DataRepository(MainDbContext dbcontext, ILogger<DataRepository> logger, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<bool> AddAdminAsync(Admin admin)
        {
            await _dbcontext.Admin.AddRangeAsync(admin);
            return await SaveChangesAsync();
        }

        public async Task<Admin?> GetAdminById(int id)
        {
            return await _dbcontext.Admin.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Admin>> GetAdminByName(string name)
        {
            return await _dbcontext.Admin.Where(p => p.Name == name).ToListAsync();
        }


        public async Task<bool> UpdateAdminAsync(AdminDto admin)
        {
            var adminEntity = await GetAdminById(admin.Id);
            _mapper.Map(admin, adminEntity);
            return await SaveChangesAsync();
        }

        public async Task<bool> AddAdminAccountAsync(AdminAccount account)
        {
            await _dbcontext.AdminAccount.AddRangeAsync(account);
            return await SaveChangesAsync();
        }

        public async Task<AdminAccount?> GetAdminAccountById(int id)
        {
            return await _dbcontext.AdminAccount.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<AdminAccount?> GetAdminAccountByAccountName(string name)
        {
            return await _dbcontext.AdminAccount.Where(p => p.AccountName == name).FirstOrDefaultAsync();
        }


        public async Task<bool> UpdateAdminAccountAsync(AdminAccountDto account)
        {
            var adminAccountEntity = await GetAdminAccountById(account.Id);
            _mapper.Map(account, adminAccountEntity);
            return await SaveChangesAsync();
        }

        public async Task<bool> AddUserAsync(User user)
        {
            await _dbcontext.User.AddRangeAsync(user);
            return await SaveChangesAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _dbcontext.User.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> GetUserByName(string name)
        {
            return await _dbcontext.User.Where(p => p.Name == name).ToListAsync();
        }

        public async Task<bool> UpdateUserAsync(UserDto user)
        {
            var userEntity = await GetUserById(user.Id);
            _mapper.Map(user, userEntity);
            return await SaveChangesAsync();
        }

        public async Task<bool> AddUserAccountAsync(UserAccount account)
        {
            await _dbcontext.UserAccount.AddRangeAsync(account);
            return await SaveChangesAsync();
        }

        public async Task<UserAccount?> GetUserAccountById(int id)
        {
            return await _dbcontext.UserAccount.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<UserAccount?> GetUserAccountByAccountName(string name)
        {
            return await _dbcontext.UserAccount.Where(p => p.AccountName == name).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateUserAccountAsync(UserAccountDto account)
        {
            var userAccountEntity = await GetUserAccountById(account.Id);
            _mapper.Map(account, userAccountEntity);
            return await SaveChangesAsync();
        }

        public async Task<bool> AddDeveloperAsync(Developer developer)
        {
            await _dbcontext.Developer.AddRangeAsync(developer);
            return await SaveChangesAsync();
        }

        public async Task<Developer?> GetDeveloperById(int id)
        {
            return await _dbcontext.Developer.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Developer>> GetDeveloperByName(string name)
        {
            return await _dbcontext.Developer.Where(p => p.Name == name).ToListAsync();
        }

        public async Task<bool> UpdateDeveloperAsync(DeveloperDto developer)
        {
            var developerEntity = await GetDeveloperById(developer.Id);
            _mapper.Map(developer, developerEntity);
            return await SaveChangesAsync();
        }

        public async Task<bool> AddSecurityTagAsync(SecurityTag tag)
        {
            await _dbcontext.SecurityTag.AddRangeAsync(tag);
            return await SaveChangesAsync();
        }

        public async Task<SecurityTag?> GetSecurityTagById(int id)
        {
            return await _dbcontext.SecurityTag.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<SecurityTag>> GetSecurityTagByName(string name)
        {
            return await _dbcontext.SecurityTag.Where(p => p.AppName == name).ToListAsync();
        }

        public async Task<bool> UpdateSecurityTagAsync(SecurityTagDto tag)
        {
            var tagEntity = await GetSecurityTagById(tag.Id);
            _mapper.Map(tag, tagEntity);
            return await SaveChangesAsync();
        }

        public async Task<bool> AddRoleAccessAsync(RoleAccess role)
        {
            await _dbcontext.RoleAccess.AddRangeAsync(role);
            return await SaveChangesAsync();
        }

        public async Task<RoleAccess?> GetRoleAccessById(int id)
        {
            return await _dbcontext.RoleAccess.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RoleAccess>> GetRoleAccessByName(string name)
        {
            return await _dbcontext.RoleAccess.Where(p => p.RoleName == name).ToListAsync();
        }

        public async Task<bool> UpdateRoleAccessAsync(RoleAccessDto role)
        {
            var roleEntity = await GetRoleAccessById(role.Id);
            _mapper.Map(role, roleEntity);
            return await SaveChangesAsync();
        }

        public async Task<bool> AddUserRoleAsync(UserRole role)
        {
            await _dbcontext.UserRole.AddRangeAsync(role);
            return await SaveChangesAsync();
        }

        public async Task<UserRole?> GetUserRoleById(int id)
        {
            return await _dbcontext.UserRole.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateUserRoleAsync(UserRoleDto role)
        {
            var roleEntity = await GetUserRoleById(role.Id);
            _mapper.Map(role, roleEntity);
            return await SaveChangesAsync();
        }

        private async Task<bool> SaveChangesAsync()
        {
            return await _dbcontext.SaveChangesAsync() > 0;
        }
    }
}
