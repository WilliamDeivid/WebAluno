namespace WebAluno.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Core.Metadata.Edm;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=WebAluno")
        {
        }

        public virtual DbSet<alternativa> alternativa { get; set; }
        public virtual DbSet<alternativa_hist> alternativa_hist { get; set; }
        public virtual DbSet<aptidao> aptidao { get; set; }
        public virtual DbSet<area> area { get; set; }
        public virtual DbSet<assunto> assunto { get; set; }
        public virtual DbSet<aviso> aviso { get; set; }
        public virtual DbSet<curso> curso { get; set; }
        public virtual DbSet<disciplina> disciplina { get; set; }
        public virtual DbSet<duvida> duvida { get; set; }
        public virtual DbSet<evento> evento { get; set; }
        public virtual DbSet<grade> grade { get; set; }
        public virtual DbSet<leitura> leitura { get; set; }
        public virtual DbSet<pendencias> pendencias { get; set; }
        public virtual DbSet<prova> prova { get; set; }
        public virtual DbSet<prova_hist> prova_hist { get; set; }
        public virtual DbSet<prova_questao> prova_questao { get; set; }
        public virtual DbSet<questao> questao { get; set; }
        public virtual DbSet<questao_hist> questao_hist { get; set; }
        public virtual DbSet<questao_prova_hist> questao_prova_hist { get; set; }
        public virtual DbSet<resposta> resposta { get; set; }
        public virtual DbSet<tipo> tipo { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<usuario_evento> usuario_evento { get; set; }
        public virtual DbSet<usuario_prova> usuario_prova { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<alternativa>()
                .Property(e => e.DSALTERNATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<alternativa_hist>()
                .Property(e => e.DSALTERNATIVAHIST)
                .IsUnicode(false);

            modelBuilder.Entity<area>()
                .Property(e => e.DSAREA)
                .IsUnicode(false);

            modelBuilder.Entity<area>()
                .HasMany(e => e.disciplina)
                .WithRequired(e => e.area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<assunto>()
                .Property(e => e.DSASSUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<aviso>()
                .Property(e => e.DSAVISO)
                .IsUnicode(false);

            modelBuilder.Entity<aviso>()
                .HasMany(e => e.leitura)
                .WithRequired(e => e.aviso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<curso>()
                .Property(e => e.DSCURSO)
                .IsUnicode(false);

            modelBuilder.Entity<curso>()
                .HasMany(e => e.grade)
                .WithRequired(e => e.curso)
                .HasForeignKey(e => new { e.CDCURSO, e.CDDISCIPLINA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<disciplina>()
                .Property(e => e.DSDISCIPLINA)
                .IsUnicode(false);

            modelBuilder.Entity<duvida>()
                .Property(e => e.DSDUVIDA)
                .IsUnicode(false);

            modelBuilder.Entity<evento>()
                .Property(e => e.DSEVENTO)
                .IsUnicode(false);

            modelBuilder.Entity<evento>()
                .HasMany(e => e.prova)
                .WithRequired(e => e.evento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<evento>()
                .HasMany(e => e.usuario_evento)
                .WithRequired(e => e.evento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<grade>()
                .Property(e => e.DSGRADE)
                .IsUnicode(false);

            modelBuilder.Entity<pendencias>()
                .Property(e => e.DSJUSTIFICATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<prova_hist>()
                .Property(e => e.DSMOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<prova_hist>()
                .HasMany(e => e.questao_prova_hist)
                .WithRequired(e => e.prova_hist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<prova_questao>()
                .HasMany(e => e.resposta)
                .WithRequired(e => e.prova_questao)
                .HasForeignKey(e => new { e.prova_questao_CDPROVA, e.prova_questao_CDQUESTAO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<questao>()
                .Property(e => e.DSQUESTAO)
                .IsUnicode(false);

            modelBuilder.Entity<questao_hist>()
                .Property(e => e.DSMOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<questao_hist>()
                .Property(e => e.DSQUESTAOHIST)
                .IsUnicode(false);

            modelBuilder.Entity<questao_hist>()
                .Property(e => e.CDDISCIPLINA)
                .IsUnicode(false);

            modelBuilder.Entity<questao_hist>()
                .HasMany(e => e.alternativa_hist)
                .WithOptional(e => e.questao_hist)
                .HasForeignKey(e => e.CDQUESTAO);

            modelBuilder.Entity<questao_prova_hist>()
                .Property(e => e.DSQUESTAOPROVAHIST)
                .IsUnicode(false);

            modelBuilder.Entity<resposta>()
                .HasMany(e => e.duvida)
                .WithRequired(e => e.resposta)
                .HasForeignKey(e => new { e.resposta_CDRESPOSTA, e.resposta_prova_questao_CDPROVA, e.resposta_prova_questao_CDQUESTAO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<resposta>()
                .HasMany(e => e.usuario_prova)
                .WithRequired(e => e.resposta)
                .HasForeignKey(e => new { e.CDRESPOSTA, e.CDPROVA, e.CDQUESTAO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo>()
                .Property(e => e.DSTIPO)
                .IsUnicode(false);

            modelBuilder.Entity<tipo>()
                .HasMany(e => e.usuario)
                .WithRequired(e => e.tipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.DSUSUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.DSCIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.DSENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.AUTH_ID)
                .IsUnicode(false);
        }
    }
}
