using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class Country
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; } = string.Empty;
        [Required]
        [MaxLength(10)]
        public string CountryCode { get; set; } = string.Empty;
    }
}
