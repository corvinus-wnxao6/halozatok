using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HajosTeszt.TarotModel
{
    public partial class SzamhaloContext : DbContext
    {
        public SzamhaloContext()
        {
        }

        public SzamhaloContext(DbContextOptions<SzamhaloContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Wnxao6> Wnxao6s { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=Szamhalo;Persist Security Info=True;User ID=szamhalo;Password=keszulaleadando");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hungarian_CI_AS");

            

            modelBuilder.Entity<Wnxao6>(entity =>
            {
                entity.HasKey(e => e.SkTarot);

                entity.ToTable("WNXAO6");

                entity.Property(e => e.SkTarot)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SK_tarot");

                entity.Property(e => e.Tarotszoveg)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsFixedLength(true);
            });

            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
