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
    public class TbInvestimentosController : Controller
    {
        private readonly SYSTEMBANKUNIPIMContext _context;

        public TbInvestimentosController(SYSTEMBANKUNIPIMContext context)
        {
            _context = context;
        }

        // GET: TbInvestimentoes
        public async Task<IActionResult> Index()
        {
            var sYSTEMBANKUNIPIMContext = _context.TbInvestimento.Include(t => t.IdCarteiraNavigation).Include(t => t.IdTipoInvestimentoNavigation);
            return View(await sYSTEMBANKUNIPIMContext.ToListAsync());
        }

        // GET: TbInvestimentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbInvestimento = await _context.TbInvestimento
                .Include(t => t.IdCarteiraNavigation)
                .Include(t => t.IdTipoInvestimentoNavigation)
                .FirstOrDefaultAsync(m => m.IdInvestimento == id);
            if (tbInvestimento == null)
            {
                return NotFound();
            }

            return View(tbInvestimento);
        }

        // GET: TbInvestimentoes/Create
        public IActionResult Create()
        {
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira");
            ViewData["IdTipoInvestimento"] = new SelectList(_context.TbTipoInvestimento, "IdTipoInvestimento", "DescricaoInvestimento");
            return View();
        }

        // POST: TbInvestimentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdInvestimento,IdCarteira,IdTipoInvestimento,Quantidade")] TbInvestimento tbInvestimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbInvestimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira", tbInvestimento.IdCarteira);
            ViewData["IdTipoInvestimento"] = new SelectList(_context.TbTipoInvestimento, "IdTipoInvestimento", "DescricaoInvestimento", tbInvestimento.IdTipoInvestimento);
            return View(tbInvestimento);
        }

        // GET: TbInvestimentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbInvestimento = await _context.TbInvestimento.FindAsync(id);
            if (tbInvestimento == null)
            {
                return NotFound();
            }
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira", tbInvestimento.IdCarteira);
            ViewData["IdTipoInvestimento"] = new SelectList(_context.TbTipoInvestimento, "IdTipoInvestimento", "DescricaoInvestimento", tbInvestimento.IdTipoInvestimento);
            return View(tbInvestimento);
        }

        // POST: TbInvestimentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdInvestimento,IdCarteira,IdTipoInvestimento,Quantidade")] TbInvestimento tbInvestimento)
        {
            if (id != tbInvestimento.IdInvestimento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbInvestimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbInvestimentoExists(tbInvestimento.IdInvestimento))
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
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira", tbInvestimento.IdCarteira);
            ViewData["IdTipoInvestimento"] = new SelectList(_context.TbTipoInvestimento, "IdTipoInvestimento", "DescricaoInvestimento", tbInvestimento.IdTipoInvestimento);
            return View(tbInvestimento);
        }

        // GET: TbInvestimentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbInvestimento = await _context.TbInvestimento
                .Include(t => t.IdCarteiraNavigation)
                .Include(t => t.IdTipoInvestimentoNavigation)
                .FirstOrDefaultAsync(m => m.IdInvestimento == id);
            if (tbInvestimento == null)
            {
                return NotFound();
            }

            return View(tbInvestimento);
        }

        // POST: TbInvestimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbInvestimento = await _context.TbInvestimento.FindAsync(id);
            _context.TbInvestimento.Remove(tbInvestimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbInvestimentoExists(int id)
        {
            return _context.TbInvestimento.Any(e => e.IdInvestimento == id);
        }
    }
}
