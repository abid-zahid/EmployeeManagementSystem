using EmployeeManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }
        public DepartmentViewModel Department { get; set; }

    }
}
