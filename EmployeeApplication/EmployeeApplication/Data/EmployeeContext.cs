using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Models;

namespace EmployeeApplication.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeApplication.Models.Department> Department { get; set; }

        public DbSet<EmployeeApplication.Models.Employee> Employee { get; set; }
    }
}
