namespace EmployeeManagementSystem.Models
{
    public class BaseModel
    {
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
