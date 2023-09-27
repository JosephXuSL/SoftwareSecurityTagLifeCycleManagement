namespace SSTLifeCycleManagement.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public SecurityTag APPSecurityTag { get; set; }
        public int RoleId { get; set;}
        public RoleAccess Role { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
