using SSTLifeCycleManagement.Entities;
using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class UserDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(18)]
        public string IdentityCardNumber { get; set; }
        public string Gen { get; set; }
        [MaxLength(10)]
        public string UserStatus { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public int DeveloperId { get; set; }
    }
}
