namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proj_db.questao")]
    public partial class questao
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDQUESTAO { get; set; }

        [Required]
        [StringLength(500)]
        public string DSQUESTAO { get; set; }

        public int NRDIFICULDADE { get; set; }

        public int FGSITUACAO { get; set; }

        public int CODFORMULADOR { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDASSUNTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDDISCIPLINA { get; set; }
    }
}
