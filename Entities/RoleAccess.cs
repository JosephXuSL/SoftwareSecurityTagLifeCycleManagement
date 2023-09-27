namespace SSTLifeCycleManagement.Entities
{
    public class RoleAccess
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public bool ReadPermission { get; set; }
        public bool WritePermission { get; set; }
        public bool AdminPermission { get; set; }
        public int DeveloperId { get; set; }
    }
}
