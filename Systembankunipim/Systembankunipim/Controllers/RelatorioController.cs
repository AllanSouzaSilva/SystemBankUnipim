using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Systembankunipim.Data;

namespace Systembankunipim.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly SYSTEMBANKUNIPIMContext _context;

        public RelatorioController(SYSTEMBANKUNIPIMContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
