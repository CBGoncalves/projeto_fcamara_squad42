using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication1.Domains;

#nullable disable

namespace WebApplication1.Contexts
{
    public partial class AgendaFCContext : DbContext
    {
        public AgendaFCContext()
        {
        }

        public AgendaFCContext(DbContextOptions<AgendaFCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agendamento> Agendamentos { get; set; }
        public virtual DbSet<Escritorio> Escritorios { get; set; }
        public virtual DbSet<TipoAgendamento> TipoAgendamentos { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Turno> Turnos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-FJFMAOG\\SQLEXPRESS;Database=AgendaFC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Agendamento>(entity =>
            {
                entity.HasKey(e => e.IdAgendamento)
                    .HasName("PK__Agendame__DC0823C932869533");

                entity.ToTable("Agendamento");

                entity.Property(e => e.DataAgendamento).HasColumnType("date");

                entity.HasOne(d => d.IdEscritorioNavigation)
                    .WithMany(p => p.Agendamentos)
                    .HasForeignKey(d => d.IdEscritorio)
                    .HasConstraintName("FK__Agendamen__IdEsc__47DBAE45");

                entity.HasOne(d => d.IdTipoAgendamentoNavigation)
                    .WithMany(p => p.Agendamentos)
                    .HasForeignKey(d => d.IdTipoAgendamento)
                    .HasConstraintName("FK__Agendamen__IdTip__46E78A0C");

                entity.HasOne(d => d.IdTurnoNavigation)
                    .WithMany(p => p.Agendamentos)
                    .HasForeignKey(d => d.IdTurno)
                    .HasConstraintName("FK__Agendamen__IdTur__48CFD27E");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Agendamentos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Agendamen__IdUsu__45F365D3");
            });

            modelBuilder.Entity<Escritorio>(entity =>
            {
                entity.HasKey(e => e.IdEscritorio)
                    .HasName("PK__Escritor__2BD496EDF85774BD");

                entity.ToTable("Escritorio");

                entity.HasIndex(e => e.EnderecoEscritorio, "UQ__Escritor__2587CF983315E903")
                    .IsUnique();

                entity.Property(e => e.EnderecoEscritorio)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TituloEscritorio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoAgendamento>(entity =>
            {
                entity.HasKey(e => e.IdTipoAgendamento)
                    .HasName("PK__TipoAgen__9099F97042A3E949");

                entity.ToTable("TipoAgendamento");

                entity.HasIndex(e => e.TituloTipoAgendamento, "UQ__TipoAgen__513D54A518C9983D")
                    .IsUnique();

                entity.Property(e => e.TituloTipoAgendamento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TipoUsua__CA04062B9E0F2256");

                entity.ToTable("TipoUsuario");

                entity.HasIndex(e => e.TituloTipoUsuario, "UQ__TipoUsua__37BBE07E3FB913FA")
                    .IsUnique();

                entity.Property(e => e.TituloTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.IdTurno)
                    .HasName("PK__Turno__C1ECF79A0E8ED37C");

                entity.ToTable("Turno");

                entity.HasIndex(e => e.TituloTurno, "UQ__Turno__A840B41F8D2C7F28")
                    .IsUnique();

                entity.Property(e => e.TituloTurno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97C297A9CF");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Email, "UQ__Usuario__A9D105347515EF0F")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuario__IdTipoU__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
