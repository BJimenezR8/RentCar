using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentCar.Models;

namespace RentCar.Controllers
{
    public class InspeccionesController : Controller
    {
        private readonly DbAa5e9fBryantj001Context _context;

        public InspeccionesController(DbAa5e9fBryantj001Context context)
        {
            _context = context;
        }

        // GET: Inspecciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inspecciones.ToListAsync());
        }

        // GET: Inspecciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccione = await _context.Inspecciones
                .FirstOrDefaultAsync(m => m.IdTransaccion == id);
            if (inspeccione == null)
            {
                return NotFound();
            }

            return View(inspeccione);
        }

        // GET: Inspecciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inspecciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransaccion,IdVehiculo,IdCliente,Defectos,CantidadCombustible,Respuesta,Gato,Fecha,EmpleadoInspeccion,Estado")] Inspeccione inspeccione)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inspeccione);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inspeccione);
        }

        // GET: Inspecciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccione = await _context.Inspecciones.FindAsync(id);
            if (inspeccione == null)
            {
                return NotFound();
            }
            return View(inspeccione);
        }

        // POST: Inspecciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTransaccion,IdVehiculo,IdCliente,Defectos,CantidadCombustible,Respuesta,Gato,Fecha,EmpleadoInspeccion,Estado")] Inspeccione inspeccione)
        {
            if (id != inspeccione.IdTransaccion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inspeccione);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InspeccioneExists(inspeccione.IdTransaccion))
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
            return View(inspeccione);
        }

        // GET: Inspecciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccione = await _context.Inspecciones
                .FirstOrDefaultAsync(m => m.IdTransaccion == id);
            if (inspeccione == null)
            {
                return NotFound();
            }

            return View(inspeccione);
        }

        // POST: Inspecciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inspeccione = await _context.Inspecciones.FindAsync(id);
            if (inspeccione != null)
            {
                _context.Inspecciones.Remove(inspeccione);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InspeccioneExists(int id)
        {
            return _context.Inspecciones.Any(e => e.IdTransaccion == id);
        }
    }
}
