using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompanyMvc.Data;
using CompanyMvc.Models;

namespace CompanyMvc.Controllers
{
    public class DemandeDeCongéController : Controller
    {
        private readonly CompanyMvcContext _context;

        public DemandeDeCongéController(CompanyMvcContext context)
        {
            _context = context;
        }

        // GET: DemandeDeCongé
        public async Task<IActionResult> Index()
        {
            return View(await _context.DemandeDeCongé.ToListAsync());
        }

        // GET: DemandeDeCongé/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demandeDeCongé = await _context.DemandeDeCongé
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demandeDeCongé == null)
            {
                return NotFound();
            }

            return View(demandeDeCongé);
        }

        // GET: DemandeDeCongé/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DemandeDeCongé/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateDebut,DateRetour,TypeDeCongé,Cause,NombreJours,Status")] DemandeDeCongé demandeDeCongé)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demandeDeCongé);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demandeDeCongé);
        }

        // GET: DemandeDeCongé/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demandeDeCongé = await _context.DemandeDeCongé.FindAsync(id);
            if (demandeDeCongé == null)
            {
                return NotFound();
            }
            return View(demandeDeCongé);
        }

        // POST: DemandeDeCongé/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateDebut,DateRetour,TypeDeCongé,Cause,NombreJours,Status")] DemandeDeCongé demandeDeCongé)
        {
            if (id != demandeDeCongé.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demandeDeCongé);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemandeDeCongéExists(demandeDeCongé.Id))
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
            return View(demandeDeCongé);
        }

        // GET: DemandeDeCongé/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demandeDeCongé = await _context.DemandeDeCongé
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demandeDeCongé == null)
            {
                return NotFound();
            }

            return View(demandeDeCongé);
        }

        // POST: DemandeDeCongé/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var demandeDeCongé = await _context.DemandeDeCongé.FindAsync(id);
            _context.DemandeDeCongé.Remove(demandeDeCongé);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemandeDeCongéExists(int id)
        {
            return _context.DemandeDeCongé.Any(e => e.Id == id);
        }
    }
}
