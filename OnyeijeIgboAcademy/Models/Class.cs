using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnyeijeIgboAcademy.Models
{
    public class Class: BaseEntity
    {
        [Key]
        [Required]
        public int ClassId { get; set; }

        [Display(Name = "Class")]
        public string ClassName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Display(Name ="Start Date")]
    
        public string StartDate { get; set; }

        [Display(Name = "End Date")]
      
        public string EndDate { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        public ICollection<Assignment> Assignment { get; set; }
        public ICollection<ExamSetUp> ExamSetUp { get; set; }

    }
}
