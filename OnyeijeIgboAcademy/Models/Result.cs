using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class Result : BaseEntity
    {
        [Key]
        [Required]
        public int ResultId { get; set; }

        public string StudentName { get; set; }
        public string ExamName { get; set; }
        public string Course { get; set; }
        [Display(Name = "Total Questions")]
        public int TotalQuestions { get; set; }
        public int Attempted { get; set; }
        [Display(Name = "Not Attempted")]
        public int NotAttempted { get; set; }
        public int Correct { get; set; }
        public int InCorrect { get; set; }
        public int Score { get; set; }
    }
}
