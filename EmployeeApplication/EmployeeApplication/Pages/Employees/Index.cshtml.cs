using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;
using EmployeeApplication.ViewModel;

namespace EmployeeApplication.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeApplication.Models.EmployeeContext _context;

        public IndexModel(EmployeeApplication.Models.EmployeeContext context)
        {
            _context = context;
        }

        public IList<EmployeeViewModel> EmployeeVM { get;set; }
      
        public async Task OnGetAsync()
        {
            EmployeeVM = await _context.Employee.Include("Department").Select(x=>new EmployeeViewModel() {
                EmployeeId = x.EmployeeId,
                Name = x.Name,
                Surname = x.Surname,
                Address = x.Address,
                DepartmentName = x.Department.Name,
                ContactNumber = x.ContactNumber,
                Qualification = x.Qualification
            }).ToListAsync();
        }
    }
}
