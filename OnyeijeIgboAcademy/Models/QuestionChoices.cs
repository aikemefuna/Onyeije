using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class QuestionChoices : BaseEntity
    {
        [Key]
        [Required]
        public int AnswerId { get; set; }

        public bool IsAnswer { get; set; }

        public int ONJQuestionsId { get; set; }
        public ONJQuestions ONJQuestions { get; set; }
        public string Text { get; set; }
       
    }
}
