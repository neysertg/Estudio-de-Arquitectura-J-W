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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }
        
        public IActionResult NuestraExperiencia()
        {
            return View();
        }
        
        public IActionResult ProyectosRealizados()
        {
            return View();
        }
        
        public IActionResult ProyectosArealizar()
        {
            return View();
        }
        
        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult Comentarios()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
