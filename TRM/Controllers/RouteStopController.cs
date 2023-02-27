using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TRM.Models;

namespace TRM.Controllers
{
    public class RouteStopController : Controller
    {
        private readonly TRMContext _context;

        public RouteStopController(TRMContext context)
        {
            _context = context;
        }

        // GET: RouteStop
        public async Task<IActionResult> Index()
        {
            var tRMContext = _context.RouteStop.Include(r => r.Vehicle);
            return View(await tRMContext.ToListAsync());
        }

        // GET: RouteStop/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RouteStop == null)
            {
                return NotFound();
            }

            var routeStop = await _context.RouteStop
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.RouteStopId == id);
            if (routeStop == null)
            {
                return NotFound();
            }

            return View(routeStop);
        }

        // GET: RouteStop/Create
        public IActionResult Create()
        {
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "VehicleId", "VehicleId");
            return View();
        }

        // POST: RouteStop/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RouteStopId,RouteStopName1,RouteStopName2,RouteStopName3,VehicleId")] RouteStop routeStop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(routeStop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "VehicleId", "VehicleId", routeStop.VehicleId);
            return View(routeStop);
        }

        // GET: RouteStop/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RouteStop == null)
            {
                return NotFound();
            }

            var routeStop = await _context.RouteStop.FindAsync(id);
            if (routeStop == null)
            {
                return NotFound();
            }
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "VehicleId", "VehicleId", routeStop.VehicleId);
            return View(routeStop);
        }

        // POST: RouteStop/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RouteStopId,RouteStopName1,RouteStopName2,RouteStopName3,VehicleId")] RouteStop routeStop)
        {
            if (id != routeStop.RouteStopId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(routeStop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RouteStopExists(routeStop.RouteStopId))
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
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "VehicleId", "VehicleId", routeStop.VehicleId);
            return View(routeStop);
        }

        // GET: RouteStop/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RouteStop == null)
            {
                return NotFound();
            }

            var routeStop = await _context.RouteStop
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.RouteStopId == id);
            if (routeStop == null)
            {
                return NotFound();
            }

            return View(routeStop);
        }

        // POST: RouteStop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RouteStop == null)
            {
                return Problem("Entity set 'TRMContext.RouteStop'  is null.");
            }
            var routeStop = await _context.RouteStop.FindAsync(id);
            if (routeStop != null)
            {
                _context.RouteStop.Remove(routeStop);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RouteStopExists(int id)
        {
          return (_context.RouteStop?.Any(e => e.RouteStopId == id)).GetValueOrDefault();
        }
    }
}
