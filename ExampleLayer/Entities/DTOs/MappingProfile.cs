using AutoMapper;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<DepartmentDto, Department>()
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.DName)).ReverseMap();

            CreateMap<GradeDto, Grade>().ReverseMap();
            CreateMap<StudentDto, Student>().ReverseMap();
        }
    }
}
