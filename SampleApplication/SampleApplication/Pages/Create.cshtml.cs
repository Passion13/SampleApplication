using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleApplication.Models;

namespace SampleApplication.Pages
{
    public class CreateModel : PageModel
    {
        private readonly SampleApplication.Models.SampleContext _context;

        public CreateModel(SampleApplication.Models.SampleContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet(int? id)
        {
            PopulateDepartmentsDropDownList(_context);
           
            if (id == null)
            {
                return Page();
            }
            else
            {
                Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeId == id);

            }

            return Page();
 
        }

        [BindProperty]
        public Employee Employee { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Employee.EmployeeId > 0)
            {
                _context.Attach(Employee).State = EntityState.Modified;
            }
            else
            {
                _context.Employee.Add(Employee);
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(Employee.EmployeeId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);
        }
        public SelectList DepartmentNameSL { get; set; }
      
        public void PopulateDepartmentsDropDownList(SampleContext _context,
            object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Department
                                   orderby d.DepartmentName // Sort by name.
                                   select d;

            DepartmentNameSL = new SelectList(departmentsQuery.AsNoTracking(),
                        "DepartmentId", "DepartmentName", selectedDepartment);
        }
   

    }
}