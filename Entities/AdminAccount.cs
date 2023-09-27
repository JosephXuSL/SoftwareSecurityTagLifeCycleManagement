using Microsoft.AspNetCore.Identity;

namespace SSTLifeCycleManagement.Entities
{
    public class AdminAccount: IdentityUser
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string AccountStatus { get; set; }
    }
}
