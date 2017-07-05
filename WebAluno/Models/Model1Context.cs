using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAluno.Models
{
    public class Model1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Model1Context() : base("name=Model1Context")
        {
        }

        public System.Data.Entity.DbSet<WebAluno.Models.tipo> tipoes { get; set; }

        public System.Data.Entity.DbSet<WebAluno.Models.usuario> usuarios { get; set; }
    }
}
