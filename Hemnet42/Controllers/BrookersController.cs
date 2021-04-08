using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hemnet41.Models;

namespace Hemnet42.Controllers
{
    public class BrookersController : Controller
    {
        private readonly HemnetContext _context;

        public BrookersController(HemnetContext context)
        {
            _context = context;
        }

        // GET: Brookers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brookers.ToListAsync());
        }

        // GET: Brookers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brooker = await _context.Brookers
                .FirstOrDefaultAsync(m => m.BrookerId == id);
            if (brooker == null)
            {
                return NotFound();
            }

            return View(brooker);
        }

        // GET: Brookers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brookers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrookerId,FirstName,LastName,Email")] Brooker brooker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brooker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brooker);
        }

        // GET: Brookers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brooker = await _context.Brookers.FindAsync(id);
            if (brooker == null)
            {
                return NotFound();
            }
            return View(brooker);
        }

        // POST: Brookers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BrookerId,FirstName,LastName,Email")] Brooker brooker)
        {
            if (id != brooker.BrookerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brooker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrookerExists(brooker.BrookerId))
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
            return View(brooker);
        }

        // GET: Brookers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brooker = await _context.Brookers
                .FirstOrDefaultAsync(m => m.BrookerId == id);
            if (brooker == null)
            {
                return NotFound();
            }

            return View(brooker);
        }

        // POST: Brookers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brooker = await _context.Brookers.FindAsync(id);
            _context.Brookers.Remove(brooker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrookerExists(int id)
        {
            return _context.Brookers.Any(e => e.BrookerId == id);
        }
    }
}
