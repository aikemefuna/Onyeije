
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.ViewModel
{
    public class AssignCourseViewModel
    {
        public AssignCourseViewModel()
        {
            Instructors = new List<string>();
           
        }
        public string Id { get; set; }
        [Required(ErrorMessage = "Course code is Required")]
        public string CourseCode { get; set; }
        [Required(ErrorMessage = "Course Title is Required")]
        public string CourseTitle { get; set; }
        [Required(ErrorMessage = "Course Summary is Required")]
        public string CourseSummary { get; set; }

        public List<string> Instructors { get; set; }
        
    }
}
