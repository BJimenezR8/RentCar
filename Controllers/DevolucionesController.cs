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
    public class DevolucionesController : Controller
    {
        private readonly DbAa5e9fBryantj001Context _context;

        public DevolucionesController(DbAa5e9fBryantj001Context context)
        {
            _context = context;
        }

        // GET: Devoluciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Devoluciones.ToListAsync());
        }

        // GET: Devoluciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucione = await _context.Devoluciones
                .FirstOrDefaultAsync(m => m.IdDevolucion == id);
            if (devolucione == null)
            {
                return NotFound();
            }

            return View(devolucione);
        }

        // GET: Devoluciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Devoluciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDevolucion,NoRenta,Empleado,Vehiculo,Cliente,FechaRenta,FechaDevolucion,MontoPorDia,CantidadDeDias,Comentario,Estado")] Devolucione devolucione)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devolucione);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devolucione);
        }

        // GET: Devoluciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucione = await _context.Devoluciones.FindAsync(id);
            if (devolucione == null)
            {
                return NotFound();
            }
            return View(devolucione);
        }

        // POST: Devoluciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDevolucion,NoRenta,Empleado,Vehiculo,Cliente,FechaRenta,FechaDevolucion,MontoPorDia,CantidadDeDias,Comentario,Estado")] Devolucione devolucione)
        {
            if (id != devolucione.IdDevolucion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devolucione);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevolucioneExists(devolucione.IdDevolucion))
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
            return View(devolucione);
        }

        // GET: Devoluciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucione = await _context.Devoluciones
                .FirstOrDefaultAsync(m => m.IdDevolucion == id);
            if (devolucione == null)
            {
                return NotFound();
            }

            return View(devolucione);
        }

        // POST: Devoluciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devolucione = await _context.Devoluciones.FindAsync(id);
            if (devolucione != null)
            {
                _context.Devoluciones.Remove(devolucione);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevolucioneExists(int id)
        {
            return _context.Devoluciones.Any(e => e.IdDevolucion == id);
        }
    }
}
