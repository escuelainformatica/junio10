using Junio10.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Junio10.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            ViewBag.grupos=CompraRepo.ListarAgrupado();
            return View();
        }
    }
}