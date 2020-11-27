using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Systembankunipim.Controllers
{
    public class Relatorio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
