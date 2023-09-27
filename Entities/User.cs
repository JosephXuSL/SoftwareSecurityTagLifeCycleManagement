namespace SSTLifeCycleManagement.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityCardNumber { get; set; }
        public string Gen { get; set; }
        public string? UserStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
    }
}