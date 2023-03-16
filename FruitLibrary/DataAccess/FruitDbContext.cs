using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FruitLibrary.DataAccess;

public partial class FruitDbContext : DbContext
{
    public FruitDbContext()
    {
    }

    public FruitDbContext(DbContextOptions<FruitDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Fruit> Fruits { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=LAPTOP-V6SM4N5A; database=FruitDB;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fruit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fruits__3214EC2766272870");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.From).HasMaxLength(50);
            entity.Property(e => e.FruitName).HasMaxLength(50);
            entity.Property(e => e.Price).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F457E3DA2");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acc)
                .HasMaxLength(50)
                .HasColumnName("acc");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .HasColumnName("pass");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
