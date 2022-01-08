using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Refugiados.Controllers
{
    public class OdontoController : Controller
    {
        public IActionResult Odonto()
        {
            return View();
        }
    }
}
