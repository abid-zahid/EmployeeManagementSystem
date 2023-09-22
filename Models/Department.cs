namespace EmployeeManagementSystem.Models
{
    public class Department : BaseModel
    {   
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
