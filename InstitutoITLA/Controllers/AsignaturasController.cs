using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstitutoITLA.Models;

namespace InstitutoITLA.Controllers
{
    public class AsignaturasController : Controller
    {
        private readonly ITLAContext _context;

        public AsignaturasController(ITLAContext context)
        {
            _context = context;
        }

        // GET: Asignaturas
        public async Task<IActionResult> InicioAsgt(string nombre)
        {
            if (nombre != null)
            {
                var filter = _context.Asignaturas.Where(s => s.Nombre.Contains(nombre));
                return View(filter);
            }
            return View(await _context.Asignaturas.ToListAsync());
        }

        // GET: Asignaturas/Details/ID
        public async Task<IActionResult> DetalleAsgt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignaturas = await _context.Asignaturas
                .FirstOrDefaultAsync(m => m.AsignaturasID == id);
            if (asignaturas == null)
            {
                return NotFound();
            }

            return View(asignaturas);
        }

        // GET: Asignaturas/Create
        public IActionResult CrearAsgt()
        {
            return View();
        }

        // POST: Asignaturas/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearAsgt([Bind("AsignaturasID,Nombre,TipoDeAsignatura")] Asignaturas asignaturas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asignaturas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(InicioAsgt));
            }
            return View(asignaturas);
        }

        // GET: Asignaturas/Edit/ID
        public async Task<IActionResult> EditarAsgt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignaturas = await _context.Asignaturas.FindAsync(id);
            if (asignaturas == null)
            {
                return NotFound();
            }
            return View(asignaturas);
        }

        // POST: Asignaturas/Edit/ID
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarAsgt(int id, [Bind("AsignaturasID,Nombre,TipoDeAsignatura")] Asignaturas asignaturas)
        {
            if (id != asignaturas.AsignaturasID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asignaturas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsignaturasExists(asignaturas.AsignaturasID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(InicioAsgt));
            }
            return View(asignaturas);
        }

        // GET: Asignaturas/Delete/ID
        public async Task<IActionResult> BorrarAsgt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignaturas = await _context.Asignaturas
                .FirstOrDefaultAsync(m => m.AsignaturasID == id);
            if (asignaturas == null)
            {
                return NotFound();
            }

            return View(asignaturas);
        }

        // POST: Asignaturas/Delete/ID
        [HttpPost, ActionName("BorrarAsgt")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asignaturas = await _context.Asignaturas.FindAsync(id);
            _context.Asignaturas.Remove(asignaturas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(InicioAsgt));
        }

        private bool AsignaturasExists(int id)
        {
            return _context.Asignaturas.Any(e => e.AsignaturasID == id);
        }
    }
}
