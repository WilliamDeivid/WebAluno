using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAluno.Models;

namespace WebAluno.Areas.Aluno.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno/Aluno
        public ActionResult Aluno()
        { 
            return View();
        }
    }
}