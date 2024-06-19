using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SunnyBlog.Data;
using SunnyBlog.Models;

namespace SunnyBlog.Controllers
{
    public class BlogContentsController : Controller
    {
        private readonly SunnyBlogContext _context;

        public BlogContentsController(SunnyBlogContext context)
        {
            _context = context;
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            _context.Category.Add(category);
            await _context.SaveChangesAsync();
            return View();
        }

        // GET: BlogContents
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogContent.ToListAsync());
        }

        // GET: BlogContents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogContent = await _context.BlogContent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogContent == null)
            {
                return NotFound();
            }

            return View(blogContent);
        }

        // GET: BlogContents/Create
        public IActionResult Create()
        {
            ViewData["Categories"] = new SelectList(_context.Set<Category>(), "Id", "Name");
            return View();
        }

        // POST: BlogContents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,CategoryId,Content,Author")] BlogContent blogContent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogContent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogContent);
        }

        // GET: BlogContents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogContent = await _context.BlogContent.FindAsync(id);
            if (blogContent == null)
            {
                return NotFound();
            }
            return View(blogContent);
        }

        // POST: BlogContents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Category,Content,Author")] BlogContent blogContent)
        {
            if (id != blogContent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogContent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogContentExists(blogContent.Id))
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
            return View(blogContent);
        }

        // GET: BlogContents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogContent = await _context.BlogContent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogContent == null)
            {
                return NotFound();
            }

            return View(blogContent);
        }

        // POST: BlogContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogContent = await _context.BlogContent.FindAsync(id);
            _context.BlogContent.Remove(blogContent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogContentExists(int id)
        {
            return _context.BlogContent.Any(e => e.Id == id);
        }
    }
}
