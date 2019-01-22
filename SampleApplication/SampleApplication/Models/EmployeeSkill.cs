using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    public class EmployeeSkill
    {
        public int EmployeeSkillId { get; set; }
        public int SkillId { get; set; }
        public int EmployeeId { get; set; }
    }
}
