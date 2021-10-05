using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudio_de_Arquitectura_J_W.Models;

namespace Estudio_de_Arquitectura_J_W.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly ILogger<ServiciosController> _logger;

        public ServiciosController(ILogger<ServiciosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Arquitectura()
        {
            return View();
        }

        public IActionResult Consultoria()
        {
            return View();
        }

        public IActionResult Construccion()
        {
            return View();
        }


    }
}
