using AutoMapper;
using EmployeeApplication.Models;
using EmployeeApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeApplication.Pages.Departments
{
    public class CreateModel : PageModel
    {
        private readonly EmployeeApplication.Models.EmployeeContext _context;
        private readonly IMapper _mapper;
        public CreateModel(EmployeeApplication.Models.EmployeeContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IActionResult> OnGet(int? id)
        {          
            DepartmentVM = new DepartmentViewModel();
            if(id!=null)
            {
                var department = await _context.Department.FirstOrDefaultAsync(m => m.DepartmentId == id);
                DepartmentVM.DepartmentId=department.DepartmentId;
                DepartmentVM.Name = department.Name;

                if (DepartmentVM == null)
                {
                    return NotFound();
                }
            }
            DepartmentVM.DepartmentList = await _context.Department.ToListAsync();

            return Page();
        }

        [BindProperty]
        public DepartmentViewModel DepartmentVM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToPage("./Create");
                }
                var department = _mapper.Map<Department>(DepartmentVM);
                if (department.DepartmentId > 0)
                {
                    _context.Attach(department).State = EntityState.Modified;
                }
                else
                {
                    _context.Department.Add(department);
                }
                await _context.SaveChangesAsync();

                return RedirectToPage("./Create");
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
           
        }
     
    }
}