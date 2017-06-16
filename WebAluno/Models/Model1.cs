namespace WebAluno.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<tipo> tipo { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<C__migrationhistory> C__migrationhistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<C__migrationhistory>()
                .Property(e => e.MigrationId)
                .IsUnicode(false);

            modelBuilder.Entity<C__migrationhistory>()
                .Property(e => e.ContextKey)
                .IsUnicode(false);

            modelBuilder.Entity<C__migrationhistory>()
                .Property(e => e.ProductVersion)
                .IsUnicode(false);
        }
    }
}
