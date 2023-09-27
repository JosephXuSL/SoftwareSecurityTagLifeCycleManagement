using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class People
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength (50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(10)]
        public string Country { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }     
    }
}