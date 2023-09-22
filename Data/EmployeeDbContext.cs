using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasData(
                    new Department { Id = Guid.NewGuid(), DepartmentName = "HR", IsActive = true, CreatedAt = DateTime.UtcNow },
                    new Department { Id = Guid.NewGuid(), DepartmentName = "Marketing", IsActive = true, CreatedAt = DateTime.UtcNow }
                );
        }
    }
}