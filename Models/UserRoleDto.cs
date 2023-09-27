using SSTLifeCycleManagement.Entities;
using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class UserRoleDto
    {
        [Required]
        public int Id { get; set; }
        public int TagId { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
