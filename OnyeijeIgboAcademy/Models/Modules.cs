using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace OnyeijeIgboAcademy.Models
{
    public class Modules: BaseEntity
    {
        [Key]
        
        public int ModuleId { get; set; }

      //  [AllowHtml]
        public string Description { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Display(Name = "Course")]
        public int CourseId { get; set; }

        public Course Courses { get; set; }

        [Display(Name = "Module Code")]
        public string ModuleCode { get; set; }

        public string Title { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<StudentModules> StudentModules { get; set; }

    }
}
