using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
           _context = context;
        }
        [AllowAnonymous]
        public async Task<IActionResult> CourseReport()
        {
            var courses = await  _context.Courses.Include(c => c.DifficultyLevel).ToListAsync();
            

            return View(courses);
        }

        [AllowAnonymous]
        public async Task<IActionResult> CourseSubscriptionReports()
        {
            var coursesSubscription = await _context.StCourseEnrollment.Include(c => c.Courses).Include( c=> c.Student).ToListAsync();



            return View(coursesSubscription);
        }

        [AllowAnonymous]
        public async Task<IActionResult> CourseDetailReport(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == id);
            var moduleCount = await _context.Modules.Where(c => c.CourseId == id).CountAsync();
            var topicCount = await _context.Topic.Where(c => c.Modules.CourseId == id).CountAsync();
            var topicFilesCount = await _context.TopicFiles.Include(c => c.Topic).Include(c => c.Topic.Modules).Include(c => c.Topic.Modules.Courses).Where(c => c.Topic.Modules.CourseId == id).CountAsync();
            var noOfSubscriptions = await _context.StCourseEnrollment.Where(c => c.CourseId == id).CountAsync();

            ViewBag.moduleCount = moduleCount;
            ViewBag.topicCount = topicCount;
            ViewBag.topicFilesCount = topicFilesCount;
            ViewBag.NoOfSubscription = noOfSubscriptions;
            return View(course);
        }
    }
}
