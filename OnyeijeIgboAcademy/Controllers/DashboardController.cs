using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnyeijeIgboAcademy.Models;
using OnyeijeIgboAcademy.DbContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace OnyeijeIgboAcademy.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        Double TotalTopics = 0;
        double TotalQuiz = 0;
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "GlobalAdmin")]
      
        public async Task<IActionResult> AdminDashboard(string newp)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (newp != null)
                {
                    ViewBag.PasswordChanged = "Yes";
                }

                var viewModel = new CourseIndex();
                ViewBag.Courses = await _context.Courses.CountAsync();
                ViewBag.Student = await _context.Student.CountAsync();

                ViewBag.Instructors = await _context.Instructor.CountAsync();
                ViewBag.CourseSubscriptions = await _context.StCourseEnrollment.CountAsync();

                var currentDate = DateTime.Now;
                var DateFromLastMonth = currentDate.AddMonths(-1);

                ViewBag.StudentRegCountFromLastMonth = await _context.Student.Where(c => c.DateCreated >= DateFromLastMonth && c.DateCreated <= currentDate).CountAsync();
                ViewBag.StudentSubscriptionCountFromLastMonth = await _context.StCourseEnrollment.Where(c => c.DateCreated >= DateFromLastMonth && c.DateCreated <= currentDate).CountAsync();
                ViewBag.InstructorsFromLastMonth = await _context.StCourseEnrollment.Where(c => c.DateCreated >= DateFromLastMonth && c.DateCreated <= currentDate).CountAsync();

                //ViewBag.CourseSubscriptions = (from row in _context.Modules select row).Count();
                ViewBag.Topics = (from row in _context.Topic select row).Count();
                ViewBag.Instructors = (from row in _context.Instructor select row).Count();
                ViewBag.Classes = (from row in _context.Class select row).Count();
                
                return View(viewModel);
            }
             return RedirectToAction("Login", "Account", new { f = "?", returnUrl = "/Dashboard/AdminDashboard"});
        }

       


        [HttpGet]
        public IActionResult btnforum_Click(object sender, EventArgs e)
        {

            string username = "admin";
            string email = "alomoge@gmail.com";
            string secretkey = "Qr5prQGpaQ=XADxgEaVSfA$$";

            string hashstring = username + email + secretkey;

            string hash = MD5Hash(hashstring);

            string qstring = "username=" + username + "&email=" + email + "&userHash=" + hash;

            return Redirect("http://localhost/ATSForum/AutoLogin.aspx?" + qstring);
        }
        public static string MD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        [HttpGet]
        public IActionResult btnforum_Click2(object sender, EventArgs e)
        {

            string username = "Antho1002";
            string email = "anthony@flexsystemsltd.com";
            string secretkey = "Qr5prQGpaQ=XADxgEaVSfA$$";

            string hashstring = username + email + secretkey;

            string hash = MD5Hash2(hashstring);

            string qstring = "username=" + username + "&email=" + email + "&userHash=" + hash;

            return Redirect("http://localhost:58137/OnlineExam/Module/Student/Instructions.aspx?" + qstring);
        }
        public static string MD5Hash2(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        public async Task<IActionResult> StudentDashboard(string newp)
        {
            
                var userEmail = HttpContext.Session.GetString("currentUser");
          

                if (userEmail == null )
                {
                    return RedirectToAction("Login", "Account", new { s = "?", returnUrl = "/Dashboard/StudentDashboard"});
                }
            if (newp != null)
            {
                ViewBag.PasswordChanged = "Yes";
            }
            var student = _context.Student.FirstOrDefault(c => c.StudentEmail == userEmail);
                if (student == null)
                {
                    return RedirectToAction("Login", "Account", new {e =  $"{userEmail}", returnUrl = "/Dashboard/StudentDashboard" });
                }
                var studentId = student.StudentId;
               var studentCourses =  _context.StCourseEnrollment.Where(c => c.StudentId == studentId).Select(c => c.CourseId).ToList().Count();
                var studentCoursesId = _context.StCourseEnrollment.Where(c => c.StudentId == studentId).Select(c => c.CourseId).ToList();
               
               
                List<int> TotalQuizCount = new List<int>();
               
                
        
            var TotalCompletedTopic = await _context.StudentTopic.Where(c => c.StudentId == studentId && c.IsCompleted == true).Select(c => c.TopicId).ToListAsync();
            var TotalTopicCount = await _context.StudentTopic.Where(c => c.StudentId == studentId).Select(c => c.TopicId).CountAsync();

            var AlltopicIds = await _context.StudentTopic.Where(c => c.StudentId == studentId).Select(c => c.TopicId).ToListAsync();
            foreach (var tId in AlltopicIds)
            {
                var quiz = await _context.Questions.Where(c => c.TopicId == tId).Select(c => c.QuestId).ToListAsync();
                TotalQuizCount.AddRange(quiz);
            }



            double TotalAvailablePointBasedOnVideosWatchedOnCoursesSubscribed = TotalTopicCount * 5;
                double TotalAvailablePointBasedOnQuizSetOnCoursesSubscribed = TotalQuizCount.Count() * 1;

                var totalAvailableScore = TotalAvailablePointBasedOnQuizSetOnCoursesSubscribed + TotalAvailablePointBasedOnVideosWatchedOnCoursesSubscribed;

                var studentProgress = (student.Points / totalAvailableScore) * 100;

                var roundedOffProgress = Math.Round(studentProgress, 2);
                ViewBag.ProgressPercentage = roundedOffProgress;

                ViewBag.CoursesSubscribed = studentCourses;
                ViewBag.CompletedTopics = TotalCompletedTopic.Count();


                return View();
           

            
        }
    }
}