using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioEM.NewFolder
{
    public class Area
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAdquisicion { get; set; }
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