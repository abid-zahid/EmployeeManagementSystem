using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.ViewModel
{
    public class DepartmentViewModel : BaseViewModel
    {
        public Guid Id { get; set; }
        
        [Required(ErrorMessage ="Department name is required")]
        public string DepartmentName { get; set; }
    }
}
