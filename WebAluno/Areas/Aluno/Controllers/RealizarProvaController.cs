using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAluno.Areas.Aluno.Controllers
{
    public class RealizarProvaController : Controller
    {
        // GET: Aluno/RealizarProva
        public ActionResult RealizarProva()
        {
            return View();
        }
        public ActionResult RealizarProvaFiltro()
        {
            return View();
        }
    }
}