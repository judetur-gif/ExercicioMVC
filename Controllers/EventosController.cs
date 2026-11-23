using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExerciciosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExerciciosMVC.Controllers
{
    public class EventosController : Controller
    {
       
        private static List<Evento> _eventos = new List<Evento>();
    
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Evento evento)
        {
            if (!ModelState.IsValid)
            {
                return View(evento);
            }

            evento.Id = _eventos.Any() ? _eventos.Max(e => e.Id) + 1 : 1;

            _eventos.Add(evento);

            return RedirectToAction("Index");
        }

        

    }
}