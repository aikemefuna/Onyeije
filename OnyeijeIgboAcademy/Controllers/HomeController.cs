using Microsoft.AspNetCore.Authorization;
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
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var currentDate = DateTime.Now;
            var DateFromLast2Months = currentDate.AddMonths(-2);

            var cous = await _context.Courses.Where(c => c.DateCreated >= DateFromLast2Months && c.DateCreated <= currentDate).ToListAsync();

            var homeModel = new HomeModelClass
            {
                Courses = cous
            };
            return View(homeModel);
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
