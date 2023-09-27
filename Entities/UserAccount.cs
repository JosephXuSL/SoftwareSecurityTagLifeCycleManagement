using Microsoft.AspNetCore.Identity;

namespace SSTLifeCycleManagement.Entities
{
    public class UserAccount: IdentityUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string AccountStatus { get; set; }
    }
}
