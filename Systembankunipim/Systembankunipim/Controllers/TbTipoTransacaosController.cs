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
    public class TbTipoTransacaosController : Controller
    {
        private readonly SYSTEMBANKUNIPIMContext _context;

        public TbTipoTransacaosController(SYSTEMBANKUNIPIMContext context)
        {
            _context = context;
        }

        // GET: TbTipoTransacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbTipoTransacao.ToListAsync());
        }

        // GET: TbTipoTransacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTipoTransacao = await _context.TbTipoTransacao
                .FirstOrDefaultAsync(m => m.IdTipoTransacao == id);
            if (tbTipoTransacao == null)
            {
                return NotFound();
            }

            return View(tbTipoTransacao);
        }

        // GET: TbTipoTransacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TbTipoTransacaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoTransacao,DescricaoTransacao")] TbTipoTransacao tbTipoTransacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbTipoTransacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbTipoTransacao);
        }

        // GET: TbTipoTransacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTipoTransacao = await _context.TbTipoTransacao.FindAsync(id);
            if (tbTipoTransacao == null)
            {
                return NotFound();
            }
            return View(tbTipoTransacao);
        }

        // POST: TbTipoTransacaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoTransacao,DescricaoTransacao")] TbTipoTransacao tbTipoTransacao)
        {
            if (id != tbTipoTransacao.IdTipoTransacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbTipoTransacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbTipoTransacaoExists(tbTipoTransacao.IdTipoTransacao))
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
            return View(tbTipoTransacao);
        }

        // GET: TbTipoTransacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbTipoTransacao = await _context.TbTipoTransacao
                .FirstOrDefaultAsync(m => m.IdTipoTransacao == id);
            if (tbTipoTransacao == null)
            {
                return NotFound();
            }

            return View(tbTipoTransacao);
        }

        // POST: TbTipoTransacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbTipoTransacao = await _context.TbTipoTransacao.FindAsync(id);
            _context.TbTipoTransacao.Remove(tbTipoTransacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbTipoTransacaoExists(int id)
        {
            return _context.TbTipoTransacao.Any(e => e.IdTipoTransacao == id);
        }
    }
}
