using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class ONJQuestions: BaseEntity
    {
        [Key]
        [Required]
        public int ONJQuestionsId { get; set; }
 
        public string Questions { get; set; }

        [Display(Name = "Status")]
        public bool IsEnabled { get; set; }

        [Display(Name = "Title")]
        public string Format { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        public ICollection<QuestionChoices> QuestionChoices { get; set; }

        public ICollection<StAssignmentAnswer> StAssignmentAnswer { get; set; }
    }
}
