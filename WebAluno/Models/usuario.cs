namespace WebAluno.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("webaluno.usuario")]
    public partial class usuario
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATRICULA { get; set; }

        [Required]
        [StringLength(255)]
        public string DSUSUARIO { get; set; }

        [StringLength(20)]
        public string DSCIDADE { get; set; }

        [StringLength(255)]
        public string DSENDERECO { get; set; }

        public long? NUMCPF { get; set; }

        public int? NUMFONE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDTIPO { get; set; }

        [Required]
        [StringLength(10)]
        public string SENHA { get; set; }

        public virtual tipo tipo { get; set; }
    }
}
