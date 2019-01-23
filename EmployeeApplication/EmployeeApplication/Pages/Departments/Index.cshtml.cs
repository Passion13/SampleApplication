using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;

namespace EmployeeApplication.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeApplication.Models.EmployeeContext _context;

        public IndexModel(EmployeeApplication.Models.EmployeeContext context)
        {
            _context = context;

        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
    }
}
