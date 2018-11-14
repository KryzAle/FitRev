using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitRev.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Inicio()
        {
            return View();
        }
    }
}