using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    public class Designation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
 
    }
}
