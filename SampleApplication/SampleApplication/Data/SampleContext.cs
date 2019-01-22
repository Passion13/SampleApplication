using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleApplication.Models
{
    public class SampleContext : DbContext
    {
        public SampleContext (DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkill { get; set; }


    }
}
