﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebAluno.Models;
using WebAluno.ViewModel;

namespace WebAluno.Controllers
{
    public class AutenticationController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Login()
        {
            VmLogin vm = new VmLogin();
            return RedirectToAction("Aluno", "Aluno", new { area = "Aluno" });
        }

        [HttpPost]
        public ActionResult Login(VmLogin vm)
        {
            if (ModelState.IsValid)
            {
                //Busca o usuário no banco com o mesmo email que foi informado na tela
                usuario usuarioDb = db.usuario.Where(u => u.MATRICULA == vm.MATRICULA).FirstOrDefault();


                if (usuarioDb == null)
                {
                    ModelState.AddModelError("", "Não existe usuário com essa matrícula");
                    return View(vm);
                }

                //Compara a senha que foi informada na tela com a senha criptografada armazenada
                //no banco
                bool senhaConfere = Crypto.VerifyHashedPassword(usuarioDb.SENHA, vm.SENHA);

                if (!senhaConfere)
                {
                    ModelState.AddModelError("", "Senha incorreta");
                    return View(vm);
                }
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
                
                return RedirectToAction("Login", "Home");

            }
            return View(vm);
        }
        
    }
}