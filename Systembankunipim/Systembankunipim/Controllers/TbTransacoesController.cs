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
    public class TbTransacoesController : Controller
    {
        private readonly SYSTEMBANKUNIPIMContext _context;

        public TbTransacoesController(SYSTEMBANKUNIPIMContext context)
        {
            _context = context;
        }

        // GET: TbTransacoes
        public async Task<IActionResult> Index()
        {
            var sYSTEMBANKUNIPIMContext = _context.TbTransacao.Include(t => t.IdCarteiraNavigation).Include(t => t.IdTipoTransacaoNavigation);
            return View(await sYSTEMBANKUNIPIMContext.ToListAsync());
        }

        // GET: TbTransacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTransacao = await _context.TbTransacao
                .Include(t => t.IdCarteiraNavigation)
                .Include(t => t.IdTipoTransacaoNavigation)
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (tbTransacao == null)
            {
                return NotFound();
            }

            return View(tbTransacao);
        }

        // GET: TbTransacoes/Create
        public IActionResult Create()
        {
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira");
            ViewData["IdTipoTransacao"] = new SelectList(_context.TbTipoTransacao, "IdTipoTransacao", "DescricaoTransacao");
            return View();
        }

        // POST: TbTransacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransacao,IdCarteira,IdTipoTransacao,ValorTransacao,CarteiraDestino,AgenciaDestino,ContaDestino")] TbTransacao tbTransacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbTransacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira", tbTransacao.IdCarteira);
            ViewData["IdTipoTransacao"] = new SelectList(_context.TbTipoTransacao, "IdTipoTransacao", "DescricaoTransacao", tbTransacao.IdTipoTransacao);
            return View(tbTransacao);
        }

        // GET: TbTransacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTransacao = await _context.TbTransacao.FindAsync(id);
            if (tbTransacao == null)
            {
                return NotFound();
            }
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira", tbTransacao.IdCarteira);
            ViewData["IdTipoTransacao"] = new SelectList(_context.TbTipoTransacao, "IdTipoTransacao", "DescricaoTransacao", tbTransacao.IdTipoTransacao);
            return View(tbTransacao);
        }

        // POST: TbTransacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTransacao,IdCarteira,IdTipoTransacao,ValorTransacao,CarteiraDestino,AgenciaDestino,ContaDestino")] TbTransacao tbTransacao)
        {
            if (id != tbTransacao.IdTransacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbTransacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbTransacaoExists(tbTransacao.IdTransacao))
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
            ViewData["IdCarteira"] = new SelectList(_context.TbCarteira, "IdCarteira", "IdCarteira", tbTransacao.IdCarteira);
            ViewData["IdTipoTransacao"] = new SelectList(_context.TbTipoTransacao, "IdTipoTransacao", "DescricaoTransacao", tbTransacao.IdTipoTransacao);
            return View(tbTransacao);
        }

        // GET: TbTransacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTransacao = await _context.TbTransacao
                .Include(t => t.IdCarteiraNavigation)
                .Include(t => t.IdTipoTransacaoNavigation)
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (tbTransacao == null)
            {
                return NotFound();
            }

            return View(tbTransacao);
        }

        // POST: TbTransacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbTransacao = await _context.TbTransacao.FindAsync(id);
            _context.TbTransacao.Remove(tbTransacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbTransacaoExists(int id)
        {
            return _context.TbTransacao.Any(e => e.IdTransacao == id);
        }
    }
}
