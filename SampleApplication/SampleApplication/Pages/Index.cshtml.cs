using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleApplication.Models;

namespace SampleApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SampleApplication.Models.SampleContext _context;

        public IndexModel(SampleApplication.Models.SampleContext context)
        {
            _context = context;
        }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

       

        public PaginatedList<Employee> Employee { get;set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            IQueryable<Employee> SortEmployee = from s in _context.Employee
                                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                SortEmployee = SortEmployee.Where(s => s.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    SortEmployee = SortEmployee.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    SortEmployee = SortEmployee.OrderBy(s => s.JoiningDate);
                    break;
                case "date_desc":
                    SortEmployee = SortEmployee.OrderByDescending(s => s.JoiningDate);
                    break;
                default:
                    SortEmployee = SortEmployee.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 3;
           Employee = await PaginatedList<Employee>.CreateAsync(
    SortEmployee.AsNoTracking(), pageIndex ?? 1, pageSize);
            
        }
    }
}
