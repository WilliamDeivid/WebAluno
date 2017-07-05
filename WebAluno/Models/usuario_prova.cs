namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proj_db.usuario_prova")]
    public partial class usuario_prova
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATRICULA { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDDUVIDA { get; set; }

        public int? STATUS { get; set; }

        public int CDEVENTO { get; set; }

        public int CDRESPOSTA { get; set; }

        public int CDPROVA { get; set; }

        public int CDQUESTAO { get; set; }

        public virtual resposta resposta { get; set; }
    }
}
