namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proj_db.alternativa_hist")]
    public partial class alternativa_hist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDALTERNATIVA { get; set; }

        [StringLength(500)]
        public string DSALTERNATIVAHIST { get; set; }

        public int? CDQUESTAO { get; set; }

        public sbyte? FGCORRETO { get; set; }

        public virtual questao_hist questao_hist { get; set; }
    }
}
