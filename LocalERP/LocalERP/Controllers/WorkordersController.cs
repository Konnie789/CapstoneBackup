using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocalERP.Models;

namespace LocalERP.Controllers
{
    public class WorkordersController : Controller
    {
        private readonly WorkorderContext _context;

        public WorkordersController(WorkorderContext context)
        {
            _context = context;
        }

        // GET: Workorders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Workorders.ToListAsync());
        }

        // GET: Workorders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workorder = await _context.Workorders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (workorder == null)
            {
                return NotFound();
            }

            return View(workorder);
        }

        // GET: Workorders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Workorders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Description,QuoteRequested,TotalMaterialCost,TotalLabourCost,TotalCost,DateCreated,DateRequiredBy,DateCompleted,DatePickedUp,ClientPhoneNumber,ClientEmail,ClientName,EstMaterialCost,EstLabourCost,EstOtherCost,EstTotalCost,EstDeliveryDate,AuthorizedBy")] Workorder workorder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workorder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workorder);
        }

        // GET: Workorders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workorder = await _context.Workorders.FindAsync(id);
            if (workorder == null)
            {
                return NotFound();
            }
            return View(workorder);
        }

        // POST: Workorders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,QuoteRequested,TotalMaterialCost,TotalLabourCost,TotalCost,DateCreated,DateRequiredBy,DateCompleted,DatePickedUp,ClientPhoneNumber,ClientEmail,ClientName,EstMaterialCost,EstLabourCost,EstOtherCost,EstTotalCost,EstDeliveryDate,AuthorizedBy")] Workorder workorder)
        {
            if (id != workorder.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workorder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkorderExists(workorder.ID))
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
            return View(workorder);
        }

        // GET: Workorders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workorder = await _context.Workorders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (workorder == null)
            {
                return NotFound();
            }

            return View(workorder);
        }

        // POST: Workorders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workorder = await _context.Workorders.FindAsync(id);
            _context.Workorders.Remove(workorder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkorderExists(int id)
        {
            return _context.Workorders.Any(e => e.ID == id);
        }
    }
}
