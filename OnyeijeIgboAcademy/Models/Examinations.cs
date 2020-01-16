using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnyeijeIgboAcademy.Models
{
   public class Examinations : BaseEntity
    {
        [Key]
        [Required]
        public int ExamId { get; set; }

        public string Description { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }

        public ICollection<ONJQuestions> Questions { get; set; }
        public ICollection<StAssignment> StAssignment { get; set; }
    }
}
