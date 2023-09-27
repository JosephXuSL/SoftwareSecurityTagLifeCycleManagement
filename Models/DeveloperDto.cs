using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class DeveloperDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Address { get; set; }

        public string BusinessCertificate { get; set; }
        public string Status { get; set; }
    }
}
