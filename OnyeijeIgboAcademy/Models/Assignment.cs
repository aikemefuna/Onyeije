using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class Assignment : BaseEntity
    {
        [Key]
        [Required]
        public int AssignmentId { get; set; }

        public string Description { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }
       
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        public ICollection<ONJQuestions> ONJQuestions { get; set; }
        public ICollection<StAssignment> StAssignment { get; set; }
    }
}
