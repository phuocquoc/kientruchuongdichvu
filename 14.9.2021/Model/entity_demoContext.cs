using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _14._9._2021.Model
{
    public partial class entity_demoContext : DbContext
    {
        public entity_demoContext()
        {
        }

        public entity_demoContext(DbContextOptions<entity_demoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Lopsh> Lopshes { get; set; }
        public virtual DbSet<Sv> Svs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;database=entity_demo;uid=root;password=khong123;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.20-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<Lopsh>(entity =>
            {
                entity.HasKey(e => e.IdLop)
                    .HasName("PRIMARY");

                entity.ToTable("lopsh");

                entity.Property(e => e.IdLop)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Lop");

                entity.Property(e => e.NameLop)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Sv>(entity =>
            {
                entity.HasKey(e => e.Mssv)
                    .HasName("PRIMARY");

                entity.ToTable("sv");

                entity.HasIndex(e => e.IdLop, "ID_Lop");

                entity.Property(e => e.Mssv)
                    .HasMaxLength(10)
                    .HasColumnName("MSSV")
                    .IsFixedLength(true);

                entity.Property(e => e.Dtb).HasColumnName("DTB");

                entity.Property(e => e.Gender).HasColumnType("int(1)");

                entity.Property(e => e.IdLop)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Lop");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ns)
                    .HasColumnType("date")
                    .HasColumnName("NS");

                entity.HasOne(d => d.IdLopNavigation)
                    .WithMany(p => p.Svs)
                    .HasForeignKey(d => d.IdLop)
                    .HasConstraintName("sv_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
