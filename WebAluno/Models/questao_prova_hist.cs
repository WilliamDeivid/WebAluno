namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proj_db.questao_prova_hist")]
    public partial class questao_prova_hist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDQUESTAO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDPROVA { get; set; }

        [StringLength(255)]
        public string DSQUESTAOPROVAHIST { get; set; }

        public virtual prova_hist prova_hist { get; set; }
    }
}
