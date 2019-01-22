using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SampleContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Employee.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
             new Employee{Name="Carson", EmployeeCode="Alexander",JoiningDate=DateTime.Parse("2005-09-01"),IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=1050,Grade=Grade.A   },
             new Employee{Name="Meredith",EmployeeCode="Alonso", JoiningDate=DateTime.Parse("2002-09-01") ,IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=4022,Grade=Grade.B  },
             new Employee{Name="Arturo",EmployeeCode="Anand",JoiningDate=DateTime.Parse("2003-09-01")     ,IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=3141,Grade=Grade.F  },
             new Employee{Name="Gytis",EmployeeCode="Barzdukas",JoiningDate=DateTime.Parse("2002-09-01")  ,IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=2021  },
             new Employee{Name="Yan",EmployeeCode="Li",JoiningDate=DateTime.Parse("2002-09-01")           ,IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=2042,Grade=Grade.A  },
             new Employee{Name="Peggy",EmployeeCode="Justice",JoiningDate=DateTime.Parse("2001-09-01")    ,IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=4041,Grade=Grade.D  },
             new Employee{Name="Laura",EmployeeCode="Norman",JoiningDate=DateTime.Parse("2003-09-01")     ,IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=2021,Grade=Grade.A  },
             new Employee{Name="Nino",EmployeeCode="Olivetto",JoiningDate=DateTime.Parse("2005-09-01")    ,IsActive=true,Email="abc@gmail.com",Address="Address",DepartmentId=2042  }
            };
            foreach (Employee s in employees)
            {
                context.Employee.Add(s);
            }
            context.SaveChanges();

            var departments = new Department[]
            {
            new Department{DepartmentId=1050,DepartmentName="Chemistry"},
            new Department{DepartmentId=4022,DepartmentName="Microeconomics"},
            new Department{DepartmentId=4041,DepartmentName="Macroeconomics"},
            new Department{DepartmentId=1045,DepartmentName="Calculus"},
            new Department{DepartmentId=3141,DepartmentName="Trigonometry"},
            new Department{DepartmentId=2021,DepartmentName="Composition"},
            new Department{DepartmentId=2042,DepartmentName="Literature"}
            };
            foreach (Department c in departments)
            {
                context.Department.Add(c);
            }
            context.SaveChanges();
            var skills = new Skill[]
                       {
             new Skill{SkillId=1,SkillName="html"},
             new Skill{SkillId=2,SkillName="c"},
             new Skill{SkillId=3,SkillName="c++"},
             new Skill{SkillId=4,SkillName="css"},
             new Skill{SkillId=5,SkillName="c#"},
             new Skill{SkillId=6,SkillName="asp.net mvc"},
             new Skill{SkillId=7,SkillName=".net core"}
                       };
            foreach (Skill c in skills)
            {
                context.Skill.Add(c);
            }
            context.SaveChanges();

            var designations = new Designation[]
           {
                 new Designation {
                     DesignationId = 1,
                     DesignationName = "Smith 17" },
                 new Designation {
                     DesignationId=2,
                     DesignationName = "Gowan 27" },
                 new Designation {
                     DesignationId = 3,
                     DesignationName = "Thompson 304" },
           };

            foreach (Designation o in designations)
            {
                context.Designation.Add(o);
            }
            context.SaveChanges();
            var employeeSkills = new EmployeeSkill[]
     {
                 new EmployeeSkill {
                     EmployeeId = 1,
                     SkillId = 1},
                 new EmployeeSkill {
                     EmployeeId= 2,
                     SkillId = 2 },
                 new EmployeeSkill {
                     EmployeeId = 3,
                     SkillId = 3 },
     };

            foreach (EmployeeSkill o in employeeSkills)
            {
                context.EmployeeSkill.Add(o);
            }
            context.SaveChanges();
        }
    }
}
