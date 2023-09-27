using SSTLifeCycleManagement.Entities;
using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class UserAccountDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string AccountName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(10)]
        public string AccountStatus { get; set; }
    }
}
