using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prueba3.Models;

namespace Prueba3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() {
            bool conexion = Bd.Conectar();
            if (conexion)
            {
                ViewData["msg"] = "Conectado a base de datos";
            }
            else
            {
                ViewData["msg"] = "Error de conexión";
            }
            return View();
        }
    }
}