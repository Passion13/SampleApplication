using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        

    }
}
