using System;
using System.ComponentModel.DataAnnotations;

namespace progra.Models
{
    public class Orden
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public Empleado Empleado { get; set; }
        public  Cliente Cliente { get; set; }
        public decimal MontoTotal { get; set; }
        public int? ClienteId { get; set; }
        public int? EmpleadoId { get; set; }
    }
}