using SSTLifeCycleManagement.Entities;
using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class SecurityTagDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string AppId { get; set; }
        [Required]
        [MaxLength(50)]
        public string AppName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Version { get; set; }
        [Required]
        [MaxLength(20)]
        public string Memory { get; set; }
        [Required]
        public int DeveloperId { get; set; }
        [Required]
        public DateTime DevelopTime { get; set; }
        public string Signature { get; set; }
        public int MaxUsers { get; set; }
        [MaxLength(10)]
        public string Status { get; set; }
    }
}
