using AutoMapper;
using OnyeijeIgboAcademy.Models;
using OnyeijeIgboAcademy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Course, CourseViewModel>();
            CreateMap<CourseViewModel, Course>();
        }
    }
}
