using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace OnyeijeIgboAcademy.Models
{
    public class Course: BaseEntity
    {
        [Key]
       
        public int CourseId { get; set; }

        public string CourseCode { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }
        public bool IsFree { get; set; }


        public float? Cost { get; set; }
        public string  CoursePreviewUrl { get; set; }
        public string  ImageUrl { get; set; }


        [Display(Name = "Title")]
        public string CourseTitle { get; set; }
 
        public string Description { get; set; }

        public int DifficultyLevelId { get; set; }
        public DifficultyLevels DifficultyLevel { get; set; }

        public ICollection<Modules> Modules { get; set; }
        public ICollection<StCourseEnrollment> StCourseEnrollment { get; set; }
        public ICollection<Class> Class { get; set; }


        public ICollection<InstructorCourse> InstructorCourses { get; set; }
    }
}
