using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAluno.ViewModel
{
    public class VmLogin
    {
        [Display(Name = "Matricula")]
        [Required]
        public int MATRICULA { get; set; }

        [Display(Name = "Senha")]
        [Required]
        public string SENHA { get; set; }
    }
}