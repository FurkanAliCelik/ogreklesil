using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ogr.Data.Models;

public partial class OgrwebContext : DbContext
{
    public OgrwebContext()
    {
    }

    public OgrwebContext(DbContextOptions<OgrwebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Giris> Girises { get; set; }

    public virtual DbSet<Çelİk> Çelİks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ogrweb;Persist Security Info=True;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=false;User ID=sa;Password=123456;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Giris>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__giris__3214EC27858A340F");

            entity.ToTable("giris");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Çelİk>(entity =>
        {
            entity.HasKey(e => e.Ogrno).HasName("PK__ÇELİK__591EB776FFA35112");

            entity.ToTable("ÇELİK");

            entity.Property(e => e.Ogrno)
                .ValueGeneratedNever()
                .HasColumnName("ogrno");
            entity.Property(e => e.Ogradi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ogradi");
            entity.Property(e => e.Ogradres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ogradres");
            entity.Property(e => e.Ogrilçe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('seyhan')")
                .HasColumnName("ogrilçe");
            entity.Property(e => e.Ogrkol)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ogrkol");
            entity.Property(e => e.Ogrsoyadi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ogrsoyadi");
            entity.Property(e => e.Ogrsınav1).HasColumnName("ogrsınav1");
            entity.Property(e => e.Ogrsınav2).HasColumnName("ogrsınav2");
            entity.Property(e => e.Ogrsınıf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ogrsınıf");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
