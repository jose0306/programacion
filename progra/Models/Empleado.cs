using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace progra.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaContratacion { get; set; }
        public List<Orden> Ordenes { get; set; }
        public int? OrdenId { get; set; }
    }
}