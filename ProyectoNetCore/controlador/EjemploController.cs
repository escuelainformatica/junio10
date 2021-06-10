using Microsoft.AspNetCore.Mvc;
using ProyectoNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoNetCore.controlador
{
    public class EjemploController : Controller
    {
        public IActionResult Index()
        {
            var listado=new List<Compra>();
            using(var contexto=new BaseEjercicioContext())
            {
                listado=contexto.Compras.ToList();
            }
            ViewBag.listado=listado;

            return View();
        }
    }
}
