using EmployeeManagementSystem.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        public Guid? Id { get; set; }

        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }
        public string? Department { get; set; }

    }
}
