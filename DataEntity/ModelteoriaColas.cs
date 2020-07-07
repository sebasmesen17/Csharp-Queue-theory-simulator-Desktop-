namespace DataEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelteoriaColas : DbContext
    {
        public ModelteoriaColas()
            : base("name=ModelteoriaColas")
        {
        }

        public virtual DbSet<Datos> Datos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Datos>()
                .Property(e => e.L)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Datos>()
                .Property(e => e.Lq)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Datos>()
                .Property(e => e.W)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Datos>()
                .Property(e => e.Wq)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Datos>()
                .Property(e => e.P)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Datos>()
                .Property(e => e.Po)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Datos>()
                .Property(e => e.Pnk)
                .HasPrecision(10, 2);
        }
    }
}
