using AutoMapper;
using EmployeeApplication.Models;
using EmployeeApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            CreateMap<DepartmentViewModel, Department>();
        }
    }
}
