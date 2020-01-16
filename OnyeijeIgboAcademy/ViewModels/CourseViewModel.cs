using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.ViewModels
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }

        public string CourseCode { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }
        public bool IsFree { get; set; }


        public string Cost { get; set; }


        [Display(Name = "Title")]
        public string CourseTitle { get; set; }

        public string Description { get; set; }
    }
}
