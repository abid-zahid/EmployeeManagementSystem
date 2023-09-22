namespace EmployeeManagementSystem.Models
{
    public class Employee : BaseModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid DepartmentId { get; set; }
        public Department? Department { get; set;}
    }
}
