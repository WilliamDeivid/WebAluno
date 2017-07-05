namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proj_db.questao_hist")]
    public partial class questao_hist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public questao_hist()
        {
            alternativa_hist = new HashSet<alternativa_hist>();
        }

        public int ID { get; set; }

        public int? CDQUESTAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_HISTORICO { get; set; }

        [StringLength(255)]
        public string DSMOTIVO { get; set; }

        [StringLength(255)]
        public string DSQUESTAOHIST { get; set; }

        public int? IDPENDENCIA { get; set; }

        public int? NRDIFICULDADE { get; set; }

        public int? CODFORMULADOR { get; set; }

        public int? CDASSUNTO { get; set; }

        [StringLength(45)]
        public string CDDISCIPLINA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alternativa_hist> alternativa_hist { get; set; }
    }
}
