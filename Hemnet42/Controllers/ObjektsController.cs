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
    public class ObjektsController : Controller
    {
        private readonly HemnetContext _context;

        public ObjektsController(HemnetContext context)
        {
            _context = context;
        }

        // GET: Objekts
        public async Task<IActionResult> IndexFinal()
        {
            var hemnetContext = _context.Objekts.Include(o => o.Brooker).Include(n => n.Coordinate);
            return View(await hemnetContext.ToListAsync());
        }

        // GET: Objekts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objekt = await _context.Objekts
                .Include(o => o.Brooker)
                .Include(n => n.Coordinate)
                .FirstOrDefaultAsync(m => m.HouseId == id);
            if (objekt == null)
            {
                return NotFound();
            }

            return View(objekt);
        }

        // GET: Objekts/Create
        public IActionResult Create()
        {
            ViewData["BrookerId"] = new SelectList(_context.Brookers, "BrookerId", "Email");
            return View();
        }

        // POST: Objekts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HouseId,Images,Adress,HousingType,FormOfLease,Price,Rooms,LivingArea,BiArea,PlotArea,Descriptions,ShowingDate,BuildYear,BrookerId")] Objekt objekt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objekt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrookerId"] = new SelectList(_context.Brookers, "BrookerId", "Email", objekt.BrookerId);
            return View(objekt);
        }
        private bool ObjektExists(int id)
        {
            return _context.Objekts.Any(e => e.HouseId == id);
        }
    
    }
}
