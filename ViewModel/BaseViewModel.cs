using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.ViewModel
{
    public class BaseViewModel
    {
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
    }
}
