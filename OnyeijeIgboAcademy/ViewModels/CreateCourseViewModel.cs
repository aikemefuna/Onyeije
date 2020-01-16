using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.ViewModel
{
    public class CreateCourseViewModel
    {
        

        [Required]
        [Display(Name = "Course Code")]
        [Remote(action: "IsCourseCodeInUse", controller: "Course")]
        public string CourseCode { get; set; }

        [Required]
        [Display(Name = "Course Title")]
        public string CourseTitle { get; set; }

        [Required]
        [Display(Name = "Course Summary")]
        public string CourseSummary { get; set; }

    }
}
