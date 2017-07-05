namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proj_db.pendencias")]
    public partial class pendencias
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int NRTIPOPEND { get; set; }

        public int TIPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime DTGERACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTAPROVACAO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATRICULA { get; set; }

        public int? NUMSITPENDENCIA { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDASSUNTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDDISCIPLINA { get; set; }

        public int? CDEVENTO { get; set; }

        public int? CDQUESTAO { get; set; }

        [StringLength(255)]
        public string DSJUSTIFICATIVA { get; set; }

        public int? MATRICULAAUX { get; set; }

        public virtual evento evento { get; set; }
    }
}
