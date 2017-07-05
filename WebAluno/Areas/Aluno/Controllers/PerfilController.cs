using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAluno.Models;

namespace WebAluno.Areas.Aluno.Controllers
{
    public class PerfilController : Controller
    {
        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Perfil_Edit()
        {
            return View();
        }
    }
}