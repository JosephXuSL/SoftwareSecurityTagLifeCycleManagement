using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSTLifeCycleManagement.Entities
{
    public class People
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [ForeignKey ("CountryCode")]
        public Country Country { get; set; }
        [Required]
        [MaxLength(10)]
        public string CountryCd { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
