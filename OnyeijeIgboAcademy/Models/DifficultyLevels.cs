using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class DifficultyLevels
    {
        [Key]
        public int DifficultyLevelId { get; set; }
        public string DifficultLevel { get; set; }
    }
}
