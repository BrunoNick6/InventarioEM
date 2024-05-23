using Microsoft.VisualBasic;

namespace InventarioEM.NewFolder
{


    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;

   /* public class InventarioContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Salida> Salidas { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Ofs> Ofs { get; set; }

        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Area)
                .WithMany(a => a.Empleados)
                .HasForeignKey(e => e.AreaId);

            modelBuilder.Entity<Entrada>()
                .HasOne(en => en.Producto)
                .WithMany(p => p.Entradas)
                .HasForeignKey(en => en.ProductoId);

            modelBuilder.Entity<Salida>()
                .HasOne(s => s.Producto)
                .WithMany(p => p.Salidas)
                .HasForeignKey(s => s.ProductoId);

            modelBuilder.Entity<Salida>()
                .HasOne(s => s.Empleado)
                .WithMany(e => e.Salidas)
                .HasForeignKey(s => s.EmpleadoId);

            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Producto)
                .WithOne()
                .HasForeignKey<Stock>(s => s.ProductoId);

            modelBuilder.Entity<Ofs>()
                .HasOne(o => o.Producto)
                .WithOne()
                .HasForeignKey<Ofs>(o => o.ProductoId);
        }
    }

    public class Area
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }
        public ICollection<Salida> Salidas { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public ICollection<Entrada> Entradas { get; set; }
        public ICollection<Salida> Salidas { get; set; }
        public Stock Stock { get; set; }
        public Ofs Ofs { get; set; }
    }

    public class Entrada
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
    }

    public class Salida
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaSalida { get; set; }
    }

    public class Stock
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }

    public class Ofs
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public DateTime FechaFueraDeServicio { get; set; }
        public string Motivo { get; set; }
    }
}

    