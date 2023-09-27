using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class RoleAccessDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public bool ReadPermission { get; set; }
        public bool WritePermission { get; set; }
        public bool AdminPermission { get; set; }
        [Required]
        public int DeveloperId { get; set; }
    }
}
