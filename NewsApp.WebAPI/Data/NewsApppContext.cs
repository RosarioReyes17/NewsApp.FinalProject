using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NewsApp.WebAPI.Models;

#nullable disable

namespace NewsApp.WebAPI.Data
{
    public partial class NewsApppContext : DbContext
    {
        public NewsApppContext()
        {
        }

        public NewsApppContext(DbContextOptions<NewsApppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulo> Articulos { get; set; }
        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Fuente> Fuentes { get; set; }
        public virtual DbSet<Paise> Paises { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-ANTHONY;Initial Catalog=NewsAppp;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.IdArticulo)
                    .HasName("pk_IdArticulo");

                entity.Property(e => e.ArticuloUrl).IsUnicode(false);

                entity.Property(e => e.Contenido).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.ImagenUrl).IsUnicode(false);

                entity.Property(e => e.Titulo).IsUnicode(false);

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("Fk_IdAutorArticulo");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("Fk_IdCategoria");

                entity.HasOne(d => d.IdFuenteNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.IdFuente)
                    .HasConstraintName("Fk_IdFuente");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("Fk_IdPais");
            });

            modelBuilder.Entity<Autore>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("Pk_IdAutor");

                entity.Property(e => e.NombreCompleto).IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("Fk_IdUsuarioAutor");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("pk_IdCategoria");

                entity.Property(e => e.NombreCategoria).IsUnicode(false);
            });

            modelBuilder.Entity<Fuente>(entity =>
            {
                entity.HasKey(e => e.IdFuente)
                    .HasName("pk_IdFuente");

                entity.Property(e => e.NombreFuente).IsUnicode(false);
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("pk_IdPais");

                entity.Property(e => e.NombrePais).IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("Pk_IdUser");

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.NombreMostrar).IsUnicode(false);

                entity.Property(e => e.NombreUsuario).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
