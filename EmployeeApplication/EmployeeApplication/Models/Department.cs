using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApplication.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [DisplayName("Department name")]
        [StringLength(100,ErrorMessage = "Department name cannot be longer than 100 characters.")]
        [Required(ErrorMessage ="Department Name is required.")]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
