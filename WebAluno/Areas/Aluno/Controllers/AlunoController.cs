using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAluno.Areas.Aluno.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno/Aluno
        public ActionResult Index()
        {
            return View();
        }
    }
}