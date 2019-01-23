using EmployeeApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.ViewModel
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }
        public List<Department> DepartmentList { get; set; }
    }
}
