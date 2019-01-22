using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    public class Employee   
    {
        public int EmployeeId { get; set; }
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [DisplayName("Employee Code")]
        [Required(ErrorMessage = "Employee Code is required.")]
        public string EmployeeCode { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="Email is required.")]
        public string Email { get; set; }
        public string Address { get; set; }
        [DisplayName("Joining Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime JoiningDate { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }
        public List<Skill> Skills { get; set; }
    }
    public enum Grade
    {
        A, B, C, D, F
    }
}
