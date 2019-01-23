using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname is required.")]
        [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters.")]
        public string Surname { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Qualification is required.")]
        [StringLength(50, ErrorMessage = "Qualification cannot be longer than 50 characters.")]
        public string Qualification { get; set; }
        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Contact Number is required.")]
        [StringLength(10, ErrorMessage = "Contact Number cannot be longer than 10 characters.")]
        public string ContactNumber { get; set; }
        [DisplayName("Department")]
        [Required(ErrorMessage = "Department is required.")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
