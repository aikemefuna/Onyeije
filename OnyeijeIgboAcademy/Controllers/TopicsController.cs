using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MediaToolkit;
using MediaToolkit.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;


namespace OnyeijeIgboAcademy.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public TopicsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Topics
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Topic.Include(t => t.Modules);
            return View(await applicationDbContext.ToListAsync());
            //foreach (var topic in applicationDbContext)
            //{
            //    var videoUrl = topic.VideoUrl;
            //    ViewBag.videourl = "/videos" + "/" + videoUrl;
            //}
        }

        // GET: Topics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topic = await _context.Topic
                .Include(t => t.Modules)
                .FirstOrDefaultAsync(m => m.TopicId == id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        // GET: Topics/Create
        public IActionResult Create()
        {
            ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title");
            return View();
        }

        // POST: Topics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Topic topic)
        {
            if (ModelState.IsValid)
            {


                var files = HttpContext.Request.Form.Files;
                foreach (var video in files)
                {
                    if (video != null && video.Length > 0)
                    {

                        var file = video;

                        //There is an error here
                        var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "videos");
                        //"/" + Path.GetFileName(pic.FileName)
                        if (file.Length > 0)
                        {
                            //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            var fileName = Path.GetFileName(file.FileName);

                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {

                                await file.CopyToAsync(fileStream);






                            }





                            topic.VideoUrl = fileName;

                        }
                    }
                }
                _context.Add(topic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", topic.ModuleId);
            return View(topic);
        }

        // GET: Topics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topic = await _context.Topic.FindAsync(id);
            if (topic == null)
            {
                return NotFound();
            }
            ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", topic.ModuleId);
            return View(topic);
        }

        // POST: Topics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Topic topic)
        {
            if (id != topic.TopicId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {

                            var file = Image;
                            //There is an error here
                            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "videos");
                            //"/" + Path.GetFileName(pic.FileName)
                            if (file.Length > 0)
                            {
                                //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                var fileName = Path.GetFileName(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {

                                    await file.CopyToAsync(fileStream);
                                    topic.VideoUrl = fileName;
                                }


                            }
                        }
                    }
                    _context.Update(topic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicExists(topic.TopicId))
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
            ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", topic.ModuleId);
            return View(topic);
        }


        // POST: Topics/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var topic = await _context.Topic.FindAsync(id);
            _context.Topic.Remove(topic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopicExists(int id)
        {
            return _context.Topic.Any(e => e.TopicId == id);
        }


        public async Task<IActionResult> StartTopic(int id)
        {
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?", returnUrl = $"/Topics/StartTopic/{id}" });
            }

            var studentId = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail).StudentId;
            var studentCoursesId = await _context.StCourseEnrollment.Where(c => c.StudentId == studentId).Select(c => c.CourseId).ToListAsync();
            foreach (var cId in studentCoursesId)
            {
                var courseTopics = await _context.Topic.Include(c => c.Modules.Courses).Where(c => c.Modules.CourseId == cId).ToListAsync();
                foreach (var tpic in courseTopics)
                {
                    if (tpic.TopicId == id)
                    {
                        if (tpic.IsCompleted == true)
                        {
                            ViewBag.IsCompleted = "Yes";
                        }
                    }
                }
            }
            var topic = _context.Topic.FirstOrDefault(c => c.TopicId == id);
            var topicFilesCount = await _context.TopicFiles.Where(c => c.TopicId == topic.TopicId).CountAsync();
            if (topicFilesCount > 0)
            {
                var topicFiles = _context.TopicFiles.Where(c => c.TopicId == topic.TopicId).Select(c => c.FileName).ToList();
                ViewBag.TopicFiles = topicFiles;
            }
            else
            {
                ViewBag.Nofile = "Yes";
            }

            ViewBag.SId = studentId;
            var topicVideo = topic.VideoUrl;
            ViewBag.TopicVideo = topicVideo;
            return View(topic);

        }

        [HttpPost]
        public async Task<JsonResult> MarkTopicCompleted([FromBody] Topic Topic)
        {
            var studentId = 0;
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail != null)
            {
                studentId = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail).StudentId;

            }
            var studentCoursesId = _context.StCourseEnrollment.Where(c => c.StudentId == studentId).Select(c => c.CourseId).ToList();
            var saveCount = 0;

           
                    var topicIds = _context.StudentTopic.Where(c => c.StudentId == studentId).Select(c => c.TopicId).ToList();
                    foreach (var tId in topicIds)
                    {
                        if (tId == Topic.TopicId)
                        {

                            var topic =  _context.StudentTopic.FirstOrDefault(c => c.TopicId == Topic.TopicId && c.StudentId == studentId);
                            if (topic.IsCompleted != true)
                            {
                                topic.IsCompleted = true;
                              
                                var addedtopic = _context.StudentTopic.Update(topic);
                                saveCount = await _context.SaveChangesAsync();
                            }


                        }
                    }
           
            if (saveCount > 0)
            {
                var student = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail);
                student.Points = student.Points + 5;
                var updatedStudent = _context.Update(student);
                var Saved = await _context.SaveChangesAsync();

                return Json(true);
            }

            else
            {
                return Json(false);
            }
        }
        public async Task<IActionResult> MyCourseTopics(int id)
        {
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?", returnUrl = $"/Topics/MyCourseTopics/{id}" });
            }

            var student = await _context.Student.FirstOrDefaultAsync(c => c.StudentEmail == loggedInUserEmail);
            if (student == null)
            {
                return RedirectToAction("Login", "Account", new { d = $"{loggedInUserEmail}", returnUrl = $"/Topics/MyCourseTopics/{id}" });
            }
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == id);
            var studentId = student.StudentId;
            var studentCoursesId = await _context.StCourseEnrollment.Where(c => c.StudentId == studentId).Select(c => c.CourseId).ToListAsync();
            List<string> files = new List<string>();
            List<Topic> topics = new List<Topic>();
            foreach (var cId in studentCoursesId)
            {
              
                if (cId == id)
                {
                   
                    

                    var courseTopics = await _context.Topic.Include(c => c.Modules.Courses).Where(c => c.Modules.CourseId == id).ToListAsync();
                    foreach (var tp in courseTopics)
                    {
                        topics.Add(tp);
                        
                        
                    }
                    var topicfiles = await _context.TopicFiles.Include(c => c.Topic).Include(c => c.Topic.Modules).Include(c => c.Topic.Modules.Courses).Where(c => c.Topic.Modules.CourseId == id).Select(c => c.FileName).ToListAsync();
                    foreach (var file in topicfiles)
                    {
                        files.Add(file);
                    }
                    if (files.Count() > 0)
                    {
                        ViewBag.Files = files;
                    }
                    else
                    {
                        ViewBag.NoFile = "Yes";
                    }

                    var video = _context.Topic.Include(m => m.Modules).Where(m => m.Modules.CourseId == id).Sum(m => m.Duration);
                    var moduleTitle = _context.Modules.Where(c => c.CourseId == id).Select(c => c.Title).ToList();

                    float totalSeconds = video;
                    TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
                    var duration = time.ToString("hh':'mm':'ss"); // 00:03:48
                    var moduleCount = _context.Modules.Where(c => c.CourseId == id).Count();

                    if (topics.Count() == 0)
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
               


                }
            }

            ViewBag.Alltopics = topics;
            return View(course);
            
        }

    }
}
