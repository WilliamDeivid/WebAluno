using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAluno.Models;
using WebAluno.ViewModel;

namespace WebAluno.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();

        // GET: Home
        public ActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public ActionResult teste()
        {
            //
            //if (ModelState.IsValid)
            //{
            //Busca o usuário no banco com a mesma matricula que foi informado na tela
            //usuario usuarioDb = db.usuario.Where(u => u.MATRICULA == MATRICULA).FirstOrDefault();

            //if (usuarioDb == null)
            //{
            //ModelState.AddModelError("", "Não existe usuário com essa matrícula");
            //return View();
            //}

            //Compara a senha que foi informada na tela com a senha criptografada armazenada
            //no banco
            //bool senhaConfere = Crypto.VerifyHashedPassword(usuarioDb.SENHA, vm.SENHA);
            // bool senhaConfere;
            //if (usuarioDb.SENHA == SENHA)
            //{
            //senhaConfere = true;
            // }
            // else
            //  {
            //ModelState.AddModelError("", "Senha incorreta");
            //return View();
            //}
            //*asd
            //Gera um token de autenticação único.
            //O método Guid.NewGuid() gera uma string aleatória que nunca se repete
            //Ex: f61dbbae2-2e29-4c6c-a445-aetdop12
            //string authId = Guid.NewGuid().ToString();
            //Session["AuthID"] = authId;

            //Cria um novo cookie com a identificacao AuthID
            //var cookie = new HttpCookie("AuthID");

            //Programa o cookie para expirar após uma semana, assim o usuário não precisa ficar 
            //logando toda hora, mesmo se fechar o browser e voltar.
            //cookie.Expires = DateTime.Now.AddDays(7);

            //Seta o valor do cookie com o token de identificação 
            //cookie.Value = authId;

            //Faz o cookie ser enviado para o browser do usuário junto com a resposta da página
            //Response.Cookies.Add(cookie);

            //Atualizar o usuário do banco com o token de autenticação
            //usuarioDb.AuthId = authId;
            //db.SaveChanges();

            return RedirectToAction("Aluno", "Aluno", new { area = "Aluno" });
            //> @Html.ActionLink("Aluno", "Aluno", new { area = "Aluno", controller = "Aluno" })

            //}
            // return View();
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}