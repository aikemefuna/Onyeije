using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProfileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult StudentProfile()
        {
           
             var studentEmail = HttpContext.Session.GetString("currentUser");
                var studentData = _context.Student.FirstOrDefault(c => c.StudentEmail == studentEmail);
                if (studentData == null)
                {
                    return View("NotFound");
                }
                ViewBag.Name = studentData.StudentFirstName;
                ViewBag.Country = studentData.Country;

                return RedirectToAction("UpdateStudentProfile");

           
           

            var student = _context.Student.FirstOrDefault(c => c.StudentEmail == studentEmail);
            if (student == null)
            {
                return View("NotFound");
            }
            ViewBag.Name = student.StudentFirstName;
            ViewBag.Country = student.Country;
            
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> StudentProfile(Student student)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var files = HttpContext.Request.Form.Files;
                    foreach (var image in files)
                    {
                        if (image != null && image.Length > 0)
                        {

                            var file = image;

                            //There is an error here
                            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                            //"/" + Path.GetFileName(pic.FileName)
                            if (file.Length > 0)
                            {
                                //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                var fileName = Guid.NewGuid().ToString() + Path.GetFileName(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                }
                                student.ProfilePics = fileName;
                            }
                        }
                    }
                    var studentToAdd = _context.Student.Add(student);
                    int saveCount =await  _context.SaveChangesAsync();
                    if (saveCount > 0)
                    {
                        return View("UpdateStudentProfile");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Data not saved");
                        return View();
                    }
                }
                return View(student);
                
            }
            catch (Exception)
            {

                throw;
            }
        }
            public IActionResult InstructorProfile()
        {
            var userEmail = HttpContext.Session.GetString("currentUser");
            if (userEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?"});
            }

            var student = _context.Student.FirstOrDefault(c => c.StudentEmail == userEmail);
            if (student == null)
            {
                return View("NotFound");
            }
            ViewBag.Name = student.StudentFirstName;
            ViewBag.Country = student.Country;
            
            return View(student);
        }
        public async Task<IActionResult> Profiles()
        {
            var userEmail = HttpContext.Session.GetString("currentUser");
            if (userEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?"});
            }
           var user = await  _userManager.FindByEmailAsync(userEmail);
            if (user == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?" });
            }
            if (await _userManager.IsInRoleAsync(user, "Instructor"))
            {
                return RedirectToAction("InstructorProfile", "Profile");
            }
            else if (await _userManager.IsInRoleAsync(user, "Student"))
            {
                return RedirectToAction("StudentProfile", "Profile");
            }
            return View();
        }
        public async Task<IActionResult> UpdateStudentProfile()
        {
            var userEmail = HttpContext.Session.GetString("currentUser");
            if (userEmail == null)
            {
                return RedirectToAction("Login", "Account", new { s = "?"});
            }
            var student = await _context.Student.FirstOrDefaultAsync(c => c.StudentEmail == userEmail);
            if (student == null)
            {
                return View("NotFound");
            }
            ViewBag.Name = student.StudentFirstName;
            ViewBag.Country = student.Country;

            return View(student);
        }

        

    }
}
