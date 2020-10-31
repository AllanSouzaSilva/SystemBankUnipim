using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Systembankunipim.Data;

namespace Systembankunipim.Controllers
{
    public class TbCarteirasController : Controller
    {
        private readonly SYSTEMBANKUNIPIMContext _context;

        public TbCarteirasController(SYSTEMBANKUNIPIMContext context)
        {
            _context = context;
        }

        // GET: TbCarteiras
        public async Task<IActionResult> Index()
        {
            var sYSTEMBANKUNIPIMContext = _context.TbCarteira.Include(t => t.IdClienteNavigation);
            return View(await sYSTEMBANKUNIPIMContext.ToListAsync());
        }

        // GET: TbCarteiras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbCarteira = await _context.TbCarteira
                .Include(t => t.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdCarteira == id);
            if (tbCarteira == null)
            {
                return NotFound();
            }

            return View(tbCarteira);
        }

        // GET: TbCarteiras/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.TbCliente, "IdCliente", "Email");
            return View();
        }

        // POST: TbCarteiras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCarteira,IdCliente,SaldoCarteira,UltimoDeposito,UltimoSaque,DataUltimaTransacao")] TbCarteira tbCarteira)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbCarteira);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.TbCliente, "IdCliente", "Email", tbCarteira.IdCliente);
            return View(tbCarteira);
        }

        // GET: TbCarteiras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbCarteira = await _context.TbCarteira.FindAsync(id);
            if (tbCarteira == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.TbCliente, "IdCliente", "Email", tbCarteira.IdCliente);
            return View(tbCarteira);
        }

        // POST: TbCarteiras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCarteira,IdCliente,SaldoCarteira,UltimoDeposito,UltimoSaque,DataUltimaTransacao")] TbCarteira tbCarteira)
        {
            if (id != tbCarteira.IdCarteira)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbCarteira);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbCarteiraExists(tbCarteira.IdCarteira))
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
            ViewData["IdCliente"] = new SelectList(_context.TbCliente, "IdCliente", "Email", tbCarteira.IdCliente);
            return View(tbCarteira);
        }

        // GET: TbCarteiras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbCarteira = await _context.TbCarteira
                .Include(t => t.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdCarteira == id);
            if (tbCarteira == null)
            {
                return NotFound();
            }

            return View(tbCarteira);
        }

        // POST: TbCarteiras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbCarteira = await _context.TbCarteira.FindAsync(id);
            _context.TbCarteira.Remove(tbCarteira);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbCarteiraExists(int id)
        {
            return _context.TbCarteira.Any(e => e.IdCarteira == id);
        }
    }
}
