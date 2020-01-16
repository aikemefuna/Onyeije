using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.ViewModel
{
    public class FindRoleViewModel
    {
        [Required]
        public string roleId { get; set; }
    }
}
