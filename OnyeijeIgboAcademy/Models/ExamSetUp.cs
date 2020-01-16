using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class ExamSetUp : BaseEntity
    {
        [Key]
        [Required]
        public int ExaminationId { get; set; }

        public int Id { get; set; }
        public Class AdmClass { get; set; }

        [Display(Name = "Status")]
        public bool IsActive { get; set; }

        [Display(Name = "Exam Name")]
        public string Title { get; set; }

        [Display(Name = "Number of Questions")]
        public int QuestionNo { get; set; }

        public string Instructions { get; set; }
    }
}
