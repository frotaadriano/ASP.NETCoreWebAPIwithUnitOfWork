using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ASP.NETCoreWebAPIwithUnitOfWork.Models;

namespace ASP.NETCoreWebAPIwithUnitOfWork.Data;

public partial class CatalogoContext : DbContext
{
    public CatalogoContext()
    {
    }

    public CatalogoContext(DbContextOptions<CatalogoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Avaliacao> Avaliacaos { get; set; }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:CatalogoDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Avaliacao>(entity =>
        {
            entity.HasKey(e => e.AvaliacaoId).HasName("PK__Avaliaca__FC95FF18067AFF1B");

            entity.ToTable("Avaliacao");

            entity.Property(e => e.Comentario).HasMaxLength(255);
            entity.Property(e => e.DataAvaliacao).HasColumnType("date");

            entity.HasOne(d => d.Produto).WithMany(p => p.Avaliacaos)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("FK__Avaliacao__Produ__38996AB5");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1E5C6293FA4");

            entity.Property(e => e.Descricao).HasMaxLength(255);
            entity.Property(e => e.Nome).HasMaxLength(100);
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.ComentarioId).HasName("PK__Comentar__F184493891AE57E4");

            entity.ToTable("Comentario");

            entity.Property(e => e.DataComentario).HasColumnType("date");
            entity.Property(e => e.Texto).HasMaxLength(255);

            entity.HasOne(d => d.Produto).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("FK__Comentari__Produ__3B75D760");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Produto__9C8800E3CD2B50B6");

            entity.ToTable("Produto");

            entity.Property(e => e.Descricao).HasMaxLength(255);
            entity.Property(e => e.Imagem).HasMaxLength(255);
            entity.Property(e => e.Nome).HasMaxLength(100);
            entity.Property(e => e.Preco).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK__Produto__Categor__35BCFE0A");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuario__2B3DE7B8E9A6D9B0");

            entity.ToTable("Usuario");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nome).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
