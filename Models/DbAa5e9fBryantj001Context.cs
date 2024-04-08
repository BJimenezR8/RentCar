using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RentCar.Models;

public partial class DbAa5e9fBryantj001Context : DbContext
{
    public DbAa5e9fBryantj001Context()
    {
    }

    public DbAa5e9fBryantj001Context(DbContextOptions<DbAa5e9fBryantj001Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Combustible> Combustibles { get; set; }

    public virtual DbSet<Devolucione> Devoluciones { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Inspeccione> Inspecciones { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Renta> Rentas { get; set; }

    public virtual DbSet<TipoVehiculo> TipoVehiculos { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//       => optionsBuilder.UseSqlServer("Data Source=SQL9001.site4now.net;Initial Catalog=db_aa5e9f_bryantj001;User Id=db_aa5e9f_bryantj001_admin;Password=bryant123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.Property(e => e.Cedula).HasMaxLength(50);
            entity.Property(e => e.LimiteDeCredito).HasMaxLength(50);
            entity.Property(e => e.NoTarjetaCr)
                .HasMaxLength(50)
                .HasColumnName("NoTarjetaCR");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.TipoPersona).HasMaxLength(50);
        });

        modelBuilder.Entity<Combustible>(entity =>
        {
            entity.HasKey(e => e.IdCombustible);

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Devolucione>(entity =>
        {
            entity.HasKey(e => e.IdDevolucion);

            entity.Property(e => e.Comentario).HasMaxLength(50);
            entity.Property(e => e.Empleado).HasMaxLength(50);
            entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");
            entity.Property(e => e.FechaRenta).HasColumnType("datetime");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado);

            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Inspeccione>(entity =>
        {
            entity.HasKey(e => e.IdTransaccion);
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca);

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo);

            entity.ToTable("Modelo");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Renta>(entity =>
        {
            entity.HasKey(e => e.IdRenta);

            entity.Property(e => e.Comentario).HasMaxLength(50);
            entity.Property(e => e.Empleado).HasMaxLength(50);
            entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");
            entity.Property(e => e.FechaRenta).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoVehiculo>(entity =>
        {
            entity.HasKey(e => e.IdTipoVehiculo);

            entity.ToTable("TipoVehiculo");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo);

            entity.ToTable("Vehiculo");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.NoChasis).HasMaxLength(50);
            entity.Property(e => e.NoMotor).HasMaxLength(50);
            entity.Property(e => e.NoPlaca).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
