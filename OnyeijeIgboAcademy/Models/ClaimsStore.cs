using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim ("Course Manager", "Course Manage"),
        

            new Claim ("SubCourse Manager", "SubCourse Manager"),
      
            new Claim ("Create Quiz", "Create Quiz"),
            new Claim ("View QuizList", "View QuizList"),
            new Claim ("Edit QuizList", "Edit QuizList"),
            new Claim ("Delete QuizList", "Delete QuizList"),

        };
    }
}
