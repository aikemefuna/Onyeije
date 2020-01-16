using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;

namespace OnyeijeIgboAcademy.Controllers
{
    public class ModulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Modules
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Modules.Include(m => m.Courses);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Modules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modules = await _context.Modules
                .Include(m => m.Courses)
                .FirstOrDefaultAsync(m => m.ModuleId == id);
            if (modules == null)
            {
                return NotFound();
            }

            return View(modules);
        }

        // GET: Modules/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseTitle");
            return View();
        }

        // POST: Modules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModuleId,Description,IsEnabled,CourseId,ModuleCode,Title,DateCreated,UserCreated,DateModified,UserModified")] Modules modules)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modules);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseTitle", modules.CourseId);
            return View(modules);
        }

        // GET: Modules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modules = await _context.Modules.FindAsync(id);
            if (modules == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseTitle", modules.CourseId);
            return View(modules);
        }

        // POST: Modules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ModuleId,Description,IsEnabled,CourseId,ModuleCode,Title,DateCreated,UserCreated,DateModified,UserModified")] Modules modules)
        {
            if (id != modules.ModuleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modules);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModulesExists(modules.ModuleId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseTitle", modules.CourseId);
            return View(modules);
        }

        // GET: Modules/Delete/5
  
        // POST: Modules/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var modules = await _context.Modules.FindAsync(id);
            _context.Modules.Remove(modules);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModulesExists(int id)
        {
            return _context.Modules.Any(e => e.ModuleId == id);
        }
        public IActionResult ModuleTopics(int id)
        {
           ViewBag.moduleTitle = _context.Modules.FirstOrDefault(c => c.ModuleId == id).Title;
            var applicationDbContext = _context.Topic.Where(c => c.ModuleId == id).ToList();

            return View(applicationDbContext);
        }
    }
}
