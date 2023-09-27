using System.ComponentModel.DataAnnotations;

namespace SSTLifeCycleManagement.Models
{
    public class AdminDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string JobNumber { get; set; }
        public string EmployeeStatus { get; set; }
        public string Gen { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
    }
}
