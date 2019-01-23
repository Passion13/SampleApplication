using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
        public string Address { get; set; }
        
        public string Qualification { get; set; }
        
        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }
    }
}
