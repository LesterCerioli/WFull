using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStock_Net.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        public ActionResult StockPos()
        {
            return View();
        }
        public ActionResult Ressup()
        {
            return View();
        }
    }
}