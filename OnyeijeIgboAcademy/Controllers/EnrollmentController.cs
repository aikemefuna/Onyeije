using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentController(ApplicationDbContext context)
        {
           _context = context;
        }
       public IActionResult Enrollments(int Id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", new { returnUrl = $"/Enrollment/Enrollments/{Id}", e = "?"});
            }
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail == null)
            {
                return RedirectToAction("Login", "Account", new { e = "?", returnUrl = $"/Enrollment/Enrollments/{Id}"});
            }


            var course = _context.Courses.FirstOrDefault(c => c.CourseId == Id);
            if (course.IsFree != true)
            {
                var courseAmount = _context.Courses.FirstOrDefault(c => c.CourseId == Id).Cost;
                ViewBag.CourseAmount = courseAmount;
            }
            var courseTitle = _context.Courses.FirstOrDefault(c => c.CourseId == Id).CourseTitle;
            var transID = DateTime.UtcNow.ToString("yyyyMMddhhmmssfff");
            var studentId = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail).StudentId;

            var courseId = course.CourseId;
            ViewBag.TransId = transID;
           
            ViewBag.payerEmail = loggedInUserEmail;
            ViewBag.CourseTitle = courseTitle; ;
            ViewBag.Key = "pk_test_83e29234069048bf3dd71e6059d06a73d30da833";
            ViewBag.courseId = courseId;
            ViewBag.studentId = studentId;
            var courseModules = _context.Modules.Where(c => c.CourseId == courseId).ToList();
            var video = _context.Topic.Include(m => m.Modules).Where(m => m.Modules.CourseId == courseId).Sum(m => m.Duration);
            var moduleDescription = _context.Modules.Where(c => c.CourseId == courseId).Select(c => c.Description).ToList();

            float totalSeconds = video;
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            var duration = time.ToString("hh':'mm':'ss"); // 00:03:48
            var moduleCount = _context.Modules.Where(c => c.CourseId == courseId).Count();

            ViewBag.moduleDescription = moduleDescription;
            ViewBag.moduleCount = moduleCount;
            ViewBag.duration = duration;
            ViewBag.Modules = courseModules;
            foreach (var module in courseModules)
            {
                var moduleId = module.ModuleId;
                var moduleTopics = _context.Topic.Where(c => c.ModuleId == moduleId).ToList();
                ViewBag.moduleTopics = moduleTopics;
            }

            var sId = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail).StudentId;

            var cId = _context.Courses.FirstOrDefault(c => c.CourseId == Id).CourseId;
          

            var isExistEnrollment = _context.StCourseEnrollment.FirstOrDefault(c => c.CourseId == cId && c.StudentId == sId);
            if (isExistEnrollment != null)
            {
                ViewBag.Enrolled = "Yes";
            }
            return View(course);

        }
        public async  Task<IActionResult> Enroll(int Id)
        {
          
            
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail == null)
            {
                return RedirectToAction("Login", "Account", new {s ="?", returnUrl = $"/Enrollment/Enroll/{Id}"});
            }

            var studentEmail = await _context.Student.FirstOrDefaultAsync(c => c.StudentEmail == loggedInUserEmail);

            var cId = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == Id);
            var couId = cId.CourseId;

            var studentId = studentEmail.StudentId;

            var isExistEnrollment = await _context.StCourseEnrollment.FirstOrDefaultAsync(c => c.CourseId == couId && c.StudentId == studentId);
            if (isExistEnrollment == null)
            {
                
                StCourseEnrollment stCourse = new StCourseEnrollment
                {
                    CourseId = couId,
                    StudentId = studentId,
                    EnrollmentDate = DateTime.UtcNow,
                };
                var enrollment = _context.StCourseEnrollment.Add(stCourse);
                var savecount =await _context.SaveChangesAsync();

                //retrieve all the modules for the course the user wants to enroll for.

                var modulesIds = await  _context.Modules.Include(c => c.Courses).Where(c => c.CourseId == couId).Select(c => c.ModuleId).ToListAsync();
                foreach (var mId in modulesIds)
                {
                    StudentModules studentModules = new StudentModules
                    {
                        ModuleId = mId,
                        StudentId = studentId,
                        StartTime = DateTime.UtcNow,
                       
                    };

                    var addedmodules = _context.StudentModules.Add(studentModules);
                    var saveCount = await _context.SaveChangesAsync();

                    var TopicIds = await _context.Topic.Include(c => c.Modules).Where(c => c.ModuleId == mId).Select(c => c.TopicId).ToListAsync();

                    foreach (var tId in TopicIds)
                    {
                        StudentTopic studentTopic = new StudentTopic
                        {
                            TopicId = tId,
                            StudentId = studentId,
                            StartTime = DateTime.UtcNow,

                        };

                        var addedTopic = _context.StudentTopic.Add(studentTopic);
                        var save = await _context.SaveChangesAsync();

                    }
                }
                

                return RedirectToAction("Enrolled", new { cId = couId });
            }
            return RedirectToAction("Enrolled", new { cId = couId});

        }

        
        public IActionResult Enrolled(int cId)
        {
            
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?", returnUrl = $"/Enrollement/Enrolled/{cId}" });
            }

            var course = _context.Courses.FirstOrDefault(c => c.CourseId == cId);

            var courseId = course.CourseId;
            var courseModules = _context.Modules.Where(c => c.CourseId == courseId).ToList();
            var video = _context.Topic.Include(m => m.Modules).Where(m => m.Modules.CourseId == courseId).Sum(m => m.Duration);
            var moduleDescription = _context.Modules.Where(c => c.CourseId == courseId).Select(c => c.Description).ToList();

            float totalSeconds = video;
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            var duration = time.ToString("hh':'mm':'ss"); // 00:03:48
            var moduleCount = _context.Modules.Where(c => c.CourseId == courseId).Count();

            ViewBag.moduleDescription = moduleDescription;
            ViewBag.moduleCount = moduleCount;
            ViewBag.duration = duration;
            ViewBag.Modules = courseModules;
            foreach (var module in courseModules)
            {
                var moduleId = module.ModuleId;
                var moduleTopics = _context.Topic.Where(c => c.ModuleId == moduleId).ToList();
                ViewBag.moduleTopics = moduleTopics;
            }
            return View(course);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> CoursePayment([FromBody] Transactions transactions)
        {
            var trans = _context.Transaction.Add(transactions);
            int changeCount = await  _context.SaveChangesAsync();
            return Json(transactions);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> UpdateCoursePayment([FromBody] string RefID)
        {
            var trans = _context.Transaction.FirstOrDefault(c => c.RefID == RefID);
            trans.PaymentStatus = "00";
            _context.Update(trans);
           var saveCount =  await  _context.SaveChangesAsync();
            return Json(trans);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> CourseEnrollement([FromBody] StCourseEnrollment  courseEnrollment)
        {
            courseEnrollment.EnrollmentDate = DateTime.UtcNow;
            var Enrollment = _context.StCourseEnrollment.Add(courseEnrollment);
            var couId = courseEnrollment.CourseId;
            var studentId = courseEnrollment.StudentId;
            var modulesIds = await _context.Modules.Include(c => c.Courses).Where(c => c.CourseId == couId).Select(c => c.ModuleId).ToListAsync();
            foreach (var mId in modulesIds)
            {
                StudentModules studentModules = new StudentModules
                {
                    ModuleId = mId,
                    StudentId = studentId,
                    StartTime = DateTime.UtcNow,

                };

                var addedmodules = _context.StudentModules.Add(studentModules);
                var saveCounter = await _context.SaveChangesAsync();

                var TopicIds = await _context.Topic.Include(c => c.Modules).Where(c => c.ModuleId == mId).Select(c => c.TopicId).ToListAsync();

                foreach (var tId in TopicIds)
                {
                    StudentTopic studentTopic = new StudentTopic
                    {
                        TopicId = tId,
                        StudentId = studentId,
                        StartTime = DateTime.UtcNow,

                    };

                    var addedTopic = _context.StudentTopic.Add(studentTopic);
                    var save = await _context.SaveChangesAsync();

                }
            }



            var saveCount = await _context.SaveChangesAsync();
            return Json(courseEnrollment);
        }
    }
    
}
