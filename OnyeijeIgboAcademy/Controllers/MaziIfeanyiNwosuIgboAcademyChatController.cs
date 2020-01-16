using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Controllers
{
    public class MaziIfeanyiNwosuIgboAcademyChatController : Controller
    {
        public readonly ApplicationDbContext _context;
        public readonly UserManager<ApplicationUser> _userManager;
        public MaziIfeanyiNwosuIgboAcademyChatController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Chats()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }
            var messages = await _context.Messages.ToListAsync();
            return View(messages);
        }
        //public async Task<IActionResult> PersonalChats()
        //{
        //    var currentUser = await _userManager.GetUserAsync(User);
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        ViewBag.CurrentUserName = currentUser.UserName;
        //    }
        //    var messages = await _context.Messages.ToListAsync();
        //    return View(messages);
        //    //var currentUser = await _userManager.GetUserAsync(User);
        //    //if (User.Identity.IsAuthenticated)
        //    //{
        //    //    ViewBag.CurrentUserName = currentUser.UserName;
        //    //}

        //    //var messages = await _context.Messages.Where(c => c.UserID == currentUser.Id && c.ToUserId == id).ToListAsync();
        //    //return View(messages);
        //}

        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                message.UserID = sender.Id;
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return Error();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
