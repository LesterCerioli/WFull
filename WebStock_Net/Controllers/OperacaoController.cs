using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStock_Net.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult Enter()
        {
            return View();
        }
        public ActionResult LancProd()
        {
            return View();
        }
        public ActionResult Exit()
        {
            return View();
        }
        public ActionResult Inv()
        {
            return View();
        }
    }
}