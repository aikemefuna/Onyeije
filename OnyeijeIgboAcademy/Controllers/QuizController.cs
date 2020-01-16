using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;

namespace OnyeijeIgboAcademy.Controllers
{
    public class QuizController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuizController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult>  Index()
        {
           var questions = await _context.Questions.Include(c => c.Topic).ToListAsync();
            foreach (var question in questions)
            {
                var module = _context.Modules.FirstOrDefault(c => c.ModuleId == question.Module).Title;
                var course = _context.Courses.FirstOrDefault(c => c.CourseId == question.Course).CourseTitle;
                ViewBag.module = module;
                ViewBag.course = course;
            }
            return View(questions);
       
        }
        [HttpGet]
        public IActionResult  CreateTopicQuiz()
        {
            ViewData["CourseId"] = new SelectList(_context.Modules, "CourseId", "Title");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTopicQuiz(Questions questions)
        {
            if (ModelState.IsValid)
            {
                var questionExist = _context.Questions.Where(c => c.TopicId == questions.TopicId && c.Question == questions.Question && c.Option1 == questions.Option1 && c.Option2 == questions.Option2 && c.Option3 == questions.Option3 && c.Option4 == questions.Option4 && c.RightAnswer == questions.RightAnswer).Count();
                if (questionExist < 1)
                {

                    var question = _context.Add(questions);
                    var savecount = await  _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
                ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "Title", questions.Course);
                ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", questions.Module);
                ViewData["TopicId"] = new SelectList(_context.Modules, "TopicId", "Title", questions.TopicId);
                ModelState.AddModelError(string.Empty, "Question exists in the question bank for this topic");
                return View(questions);
            }
            else
            {
                ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", questions.Module );
                ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "Title", questions.Course );
                ViewData["CourseId"] = new SelectList(_context.Topic, "TopicId", "Title", questions.TopicId );
                ModelState.AddModelError("", "Failed to create Quiz question");
                return View(questions);
            }
        }
        [HttpPost]
        [AllowAnonymous]
        public async  Task<IActionResult> TopicQuiz(int id)
        {
            var studentId = 0; 
            var loggedInUserEmail = HttpContext.Session.GetString("currentUser");
            if (loggedInUserEmail != null)
            {
                studentId = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail).StudentId;

            }
            var topic = await _context.Topic.FirstOrDefaultAsync(c => c.TopicId == id);
            ViewBag.TopicTitle = topic.Title;
            var student = _context.Student.FirstOrDefault(c => c.StudentEmail == loggedInUserEmail);
            ViewBag.StudentFullName = student.StudentFirstName + "" + student.StudentLastName;
            ViewBag.StudentEmail = student.StudentEmail;
            ViewBag.StudentTotalPoints = student.Points;
            var quiz = await _context.Questions.Where(c => c.TopicId == id).ToListAsync();
            return View(quiz);
        }

        [HttpGet]
        public async Task<IActionResult> EditTopicQuiz(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Questions.FindAsync(id);
            if (quiz == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Modules, "CourseId", "Title", quiz.Course);
            ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", quiz.Module);
            ViewData["TopicId"] = new SelectList(_context.Modules, "ModuleId", "Title", quiz.TopicId);
            return View(quiz);
        }

        [HttpPost]
        public async Task<IActionResult> EditTopicQuiz(int id, Questions quest)
        {
            if (id != quest.QuestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    _context.Update(quest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", "Failed to update question, Server error");
                    ViewData["CourseId"] = new SelectList(_context.Modules, "CourseId", "Title", quest.Course);
                    ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", quest.Module);
                    ViewData["TopicId"] = new SelectList(_context.Modules, "ModuleId", "Title", quest.TopicId);
                    return View(quest);
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Modules, "CourseId", "Title", quest.Course);
            ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "Title", quest.Module);
            ViewData["TopicId"] = new SelectList(_context.Modules, "ModuleId", "Title", quest.TopicId);
            return View(quest);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [AllowAnonymous]
        public JsonResult getTopicbyId(int Id)
        {
            List<Topic> list = new List<Topic>();
            list = _context.Topic.Where(a => a.ModuleId == Id).ToList();
            list.Insert(0, new Topic { TopicId = 0, Title = "Please Select" });
            return Json(new SelectList(list, "TopicId", "Title"));
        }
        public JsonResult getModulebyId(int Id)
        {
            List<Modules> list = new List<Modules>();
            list = _context.Modules.Where(a => a.CourseId == Id).ToList();
            list.Insert(0, new Modules { ModuleId = 0, Title = "Please Select" });
            return Json(new SelectList(list, "ModuleId", "Title"));
        }


    }
}