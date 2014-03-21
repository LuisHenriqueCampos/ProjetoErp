using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_JOSEREIS.Controllers
{
    public class TesteController : Controller
    {
        //
        // GET: /Teste/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabuada(int? id)
        {
            ViewBag.num = id;
            return View();
        }

    }
}
