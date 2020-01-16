using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;

using OnyeijeIgboAcademy.ViewModels;

namespace OnyeijeIgboAcademy.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public CoursesController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.Include(c => c.DifficultyLevel).ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            ViewData["DifficultyLevelId"] = new SelectList(_context.DifficultyLevels, "DifficultyLevelId", "DifficultLevel");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            if (ModelState.IsValid)
            {

                var files = HttpContext.Request.Form.Files;
                foreach (var fl in files)
                {
                    if (fl != null && fl.Length > 0)
                    {

                        var file = fl;

                        //There is an error here
                        if (file.FileName.ToLower().EndsWith("gif") || file.FileName.ToLower().EndsWith("jpeg") || file.FileName.ToLower().EndsWith("png") || file.FileName.ToLower().EndsWith("jpg") || file.FileName.ToLower().EndsWith("tiff") || file.FileName.ToLower().EndsWith("tif"))
                        {
                            var imageUploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                            if (file.Length > 0)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                //var fileName = Path.GetFileName(file.FileName);

                                using (var fileStream = new FileStream(Path.Combine(imageUploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                }
                                course.ImageUrl = fileName;

                            }
                        }
                        else
                        {
                            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "videos");
                            //"/" + Path.GetFileName(pic.FileName)
                            if (file.Length > 0)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                //var fileName = Path.GetFileName(file.FileName);

                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                }

                                course.CoursePreviewUrl = fileName;

                            }
                        }

                    }
                }

                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DifficultyLevelId"] = new SelectList(_context.DifficultyLevels, "DifficultyLevelId", "DifficultLevel", course.DifficultyLevelId);
            return View(course);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }
            ViewData["DifficultyLevelId"] = new SelectList(_context.DifficultyLevels, "DifficultyLevelId", "DifficultLevel", course.DifficultyLevelId);

            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Course course)
        {
            if (id != course.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    var files = HttpContext.Request.Form.Files;
                    foreach (var fl in files)
                    {
                        if (fl != null && fl.Length > 0)
                        {

                            var file = fl;

                            //There is an error here
                            if (file.FileName.ToLower().EndsWith("gif") || file.FileName.ToLower().EndsWith("jpeg") || file.FileName.ToLower().EndsWith("png") || file.FileName.ToLower().EndsWith("jpg") || file.FileName.ToLower().EndsWith("tiff") || file.FileName.ToLower().EndsWith("tif"))
                            {
                                var imageUploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                                if (file.Length > 0)
                                {
                                    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                    //var fileName = Path.GetFileName(file.FileName);

                                    using (var fileStream = new FileStream(Path.Combine(imageUploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                    }
                                    course.ImageUrl = fileName;

                                }
                            }
                            else
                            {
                                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "videos");
                                //"/" + Path.GetFileName(pic.FileName)
                                if (file.Length > 0)
                                {
                                    var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                    //var fileName = Path.GetFileName(file.FileName);

                                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                    }

                                    course.CoursePreviewUrl = fileName;

                                }
                            }

                        }
                    }
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CourseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DifficultyLevelId"] = new SelectList(_context.DifficultyLevels, "DifficultyLevelId", "DifficultLevel", course.DifficultyLevelId);

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }

        public IActionResult CourseModules(int id)
        {
            ViewBag.CourseTitle = _context.Courses.FirstOrDefault(c => c.CourseId == id).CourseTitle;
            var modules = _context.Modules.Include(c => c.Courses).Where(c => c.CourseId == id).ToList();
            return View(modules);
        }


        [AllowAnonymous]
        public IActionResult BeginnerCourses()
        {

            var courses = _context.Courses.Where(c => c.DifficultyLevel.DifficultLevel == "Beginner").ToList();
            foreach (var course in courses)
            {
                var courseId = course.CourseId;
                var courseModuleId = _context.Modules.FirstOrDefault(c => c.CourseId == courseId).ModuleId;
                var moduleTopicsVideoDuration = _context.Topic.Where(m => m.ModuleId == courseModuleId).Sum(m => m.Duration);
                var duration = Math.Round((moduleTopicsVideoDuration / 60), 2);
                ViewBag.duration = duration;
            }
            return View(courses);
        }
        [AllowAnonymous]
        public IActionResult FreeCourses()
        {

            var courses = _context.Courses.Where(c => c.IsFree == true).ToList();
            foreach (var course in courses)
            {
                var courseId = course.CourseId;
                var courseModuleId = _context.Modules.FirstOrDefault(c => c.CourseId == courseId).ModuleId;
                var moduleTopicsVideoDuration = _context.Topic.Where(m => m.ModuleId == courseModuleId).Sum(m => m.Duration);
                var duration = Math.Round((moduleTopicsVideoDuration / 60), 2);
                ViewBag.duration = duration;
            }
            return View(courses);
        }
        [AllowAnonymous]
        public IActionResult PaidCourses()
        {

            var courses = _context.Courses.Where(c => c.IsFree != true).ToList();
            foreach (var course in courses)
            {
                var courseId = course.CourseId;
                var courseModuleId = _context.Modules.FirstOrDefault(c => c.CourseId == courseId).ModuleId;
                var moduleTopicsVideoDuration = _context.Topic.Where(m => m.ModuleId == courseModuleId).Sum(m => m.Duration);
                var duration = Math.Round((moduleTopicsVideoDuration / 60), 2);
                ViewBag.duration = duration;
            }
            return View(courses);
        }
        [AllowAnonymous]
        public IActionResult IntermediateCourses()
        {
            var courses = _context.Courses.Where(c => c.DifficultyLevel.DifficultLevel == "Intermediate").ToList();
           

            foreach (var course in courses)
            {
                var courseId = course.CourseId;
                var courseModuleId = _context.Modules.FirstOrDefault(c => c.CourseId == courseId).ModuleId;
                var moduleTopicsVideoDuration = _context.Topic.Where(m => m.ModuleId == courseModuleId).Sum(m => m.Duration);
                var duration = Math.Round((moduleTopicsVideoDuration / 60), 2);
                ViewBag.duration = duration;
            }
            return View(courses);


        }
        [AllowAnonymous]
        public IActionResult AdvancedCourses()
        {
            var courses = _context.Courses.Where(c => c.DifficultyLevel.DifficultLevel == "Advanced").ToList();
            foreach (var course in courses)
            {
                var courseId = course.CourseId;
                var courseModuleId = _context.Modules.FirstOrDefault(c => c.CourseId == courseId).ModuleId;
                var moduleTopicsVideoDuration = _context.Topic.Where(m => m.ModuleId == courseModuleId).Sum(m => m.Duration);
                var duration = Math.Round((moduleTopicsVideoDuration / 60), 2);
                ViewBag.duration = duration;
            }
            return View(courses);
        }
        [AllowAnonymous]
        public IActionResult Courses()
        {
            var courses = _context.Courses.ToList();
            foreach (var course in courses)
            {
                var courseId = course.CourseId;
                var video = _context.Topic.Include(m => m.Modules).Where(m => m.Modules.CourseId == courseId).Sum(m => m.Duration);


                float totalSeconds = video;
                TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
                var duration = time.ToString("hh':'mm':'ss"); // 00:03:48

                ViewBag.duration = duration;
            }

            return View(courses);
        }

        [AllowAnonymous]
        public IActionResult CourseDetail(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
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
            List<Topic> top = new List<Topic>();
            foreach (var module in courseModules)
            {
                var moduleId = module.ModuleId;
                var moduleTopics = _context.Topic.Where(c => c.ModuleId == moduleId).ToList();
                top.AddRange(moduleTopics);
                ViewBag.moduleTopics = moduleTopics;
            }

            



            return View(course);
        }


        public async Task<IActionResult> MyCourses()
        {
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?", returnUrl = "/Courses/MyCourses" });
            }
            var student = await _context.Student.FirstOrDefaultAsync(c => c.StudentEmail == loggedInUserEmail);
            var studentId = student.StudentId;
            var myCourses = _context.StCourseEnrollment.Where(c => c.StudentId == studentId).Select(c => c.Courses).ToList();
            return View(myCourses);
        }

        public async Task<IActionResult> MyCourseDetail(int id)
        {
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?", returnUrl = $"/Courses/MyCourseDetail/{id}" });
            }

            var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == id);

            var courseId = course.CourseId;
            var studentId = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail).StudentId;
            var studentCoursesId = await _context.StCourseEnrollment.Where(c => c.StudentId == studentId).Select(c => c.CourseId).ToListAsync();
            List<string> files = new List<string>();

            var AllTopicIds = _context.StudentTopic.Where(c => c.StudentId == studentId).Select(c => c.TopicId).ToList();
            foreach (var item in AllTopicIds)
            {
                var topicFiles = _context.TopicFiles.Include(c => c.Topic).Where(c => c.TopicId == item).Select(c => c.FileName).ToList();
                files.AddRange(topicFiles);
            }
            if (files.Count() > 0)
            {
                ViewBag.Files = files;
            }
            else
            {
                ViewBag.NoFile = "Yes";
            }
            var video = _context.Topic.Include(m => m.Modules).Where(m => m.Modules.CourseId == courseId && m.IsCompleted == false).Sum(m => m.Duration);
            var moduleTitle = _context.Modules.Where(c => c.CourseId == courseId).Select(c => c.Title).ToList();

            float totalSeconds = video;
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            var duration = time.ToString("hh':'mm':'ss"); // 00:03:48
            var moduleCount = _context.Modules.Where(c => c.CourseId == courseId).Count();



            var AllTopic = await _context.StudentTopic.Where(c => c.StudentId == studentId && c.IsCompleted == false).Select(c => c.Topic).ToListAsync();

            //retrieve all modules of the course in View
            List<Topic> topics = new List<Topic>();
            var modulesids = await _context.Modules.Where(c => c.CourseId == course.CourseId).Select(c => c.ModuleId).ToListAsync();
            foreach (var mId in modulesids)
            {
                var topicIds = await _context.Topic.Where(c => c.ModuleId == mId).ToListAsync();
                topics.AddRange(topicIds);

            }
            if (AllTopic.Count() == 0)
            {
                ViewBag.TopicCompleted = "Yes";
            }


            ViewBag.TopicCount = topics.Count();
            ViewBag.Alltopics = topics;
            var courseIntroVideo = course.CoursePreviewUrl;
            ViewBag.courseIntro = courseIntroVideo;
            ViewBag.moduleDescription = moduleTitle;
            ViewBag.moduleCount = moduleCount;
            ViewBag.duration = duration;

            return View(course);


        }

        
    }
}
