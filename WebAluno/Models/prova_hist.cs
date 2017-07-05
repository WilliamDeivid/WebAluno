namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proj_db.prova_hist")]
    public partial class prova_hist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prova_hist()
        {
            questao_prova_hist = new HashSet<questao_prova_hist>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDPROVA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTHISTORICO { get; set; }

        [StringLength(255)]
        public string DSMOTIVO { get; set; }

        public int? IDPENDENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<questao_prova_hist> questao_prova_hist { get; set; }
    }
}
