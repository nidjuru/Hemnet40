using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hemnet41.Models;

namespace Hemnet41.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjektsController : ControllerBase
    {
        private readonly HemnetContext _context;

        public ObjektsController(HemnetContext context)
        {
            _context = context;
        }

        // GET: api/Objekts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objekt>>> GetObjekts()
        {
            return await _context.Objekts.ToListAsync();
        }

        // GET: api/Objekts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Objekt>> GetObjekt(int id)
        {


            var objekt = await _context.Objekts.FindAsync(id);

            if (objekt == null)
            {
                return NotFound();
            }

            return objekt;
        }

        // PUT: api/Objekts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjekt(int id, Objekt objekt)
        {
            if (id != objekt.HouseId)
            {
                return BadRequest();
            }

            _context.Entry(objekt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjektExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Objekts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Objekt>> PostObjekt(Objekt objekt)
        {
            _context.Objekts.Add(objekt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjekt", new { id = objekt.HouseId }, objekt);
        }

        // DELETE: api/Objekts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjekt(int id)
        {
            var objekt = await _context.Objekts.FindAsync(id);
            if (objekt == null)
            {
                return NotFound();
            }

            _context.Objekts.Remove(objekt);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObjektExists(int id)
        {
            return _context.Objekts.Any(e => e.HouseId == id);
        }
    }
}
