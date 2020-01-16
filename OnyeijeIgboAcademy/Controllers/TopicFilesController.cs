using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;

namespace OnyeijeIgboAcademy.Controllers
{
    public class TopicFilesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public TopicFilesController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: TopicFiles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TopicFiles.Include(t => t.Topic);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TopicFiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topicFiles = await _context.TopicFiles
                .Include(t => t.Topic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topicFiles == null)
            {
                return NotFound();
            }

            return View(topicFiles);
        }

        // GET: TopicFiles/Create
        public IActionResult Create()
        {
            ViewData["TopicId"] = new SelectList(_context.Topic, "TopicId", "Title");
            return View();
        }

        // POST: TopicFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TopicFiles topicFiles)
        {
            if (ModelState.IsValid)
            {

                var files = HttpContext.Request.Form.Files;
                foreach (var doc in files)
                {
                    if (doc != null && doc.Length > 0)
                    {

                        var file = doc;
                        //There is an error here
                        var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "topicFiles");
                        //"/" + Path.GetFileName(pic.FileName)
                        if (file.Length > 0)
                        {
                            //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            var fileName = Path.GetFileName(file.FileName);
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {

                                await file.CopyToAsync(fileStream);
                              
                                    topicFiles.FileName = fileName;

                               
                            }


                        }
                    }

                }

                
                _context.Add(topicFiles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TopicId"] = new SelectList(_context.Topic, "TopicId", "Title", topicFiles.TopicId);
            return View(topicFiles);
        }

        // GET: TopicFiles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topicFiles = await _context.TopicFiles.FindAsync(id);
            if (topicFiles == null)
            {
                return NotFound();
            }
            ViewData["TopicId"] = new SelectList(_context.Topic, "TopicId", "Title", topicFiles.TopicId);
            return View(topicFiles);
        }

        // POST: TopicFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TopicFiles topicFiles)
        {
            if (id != topicFiles.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    foreach (var doc in files)
                    {
                        if (doc != null && doc.Length > 0)
                        {

                            var file = doc;
                            //There is an error here
                            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "topicFiles");
                            //"/" + Path.GetFileName(pic.FileName)
                            if (file.Length > 0)
                            {
                                //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                var fileName = Path.GetFileName(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {

                                    await file.CopyToAsync(fileStream);

                                    topicFiles.FileName = fileName;


                                }


                            }
                        }

                    }

                    _context.Update(topicFiles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicFilesExists(topicFiles.Id))
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
            ViewData["TopicId"] = new SelectList(_context.Topic, "TopicId", "Title", topicFiles.TopicId);
            return View(topicFiles);
        }

   

        // POST: TopicFiles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var topicFiles = await _context.TopicFiles.FindAsync(id);
            _context.TopicFiles.Remove(topicFiles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopicFilesExists(int id)
        {
            return _context.TopicFiles.Any(e => e.Id == id);
        }
    }
}
