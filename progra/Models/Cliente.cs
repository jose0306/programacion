using System.Collections.Generic;

namespace progra.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public  List<Orden> Ordenes { get; set; }
        public int? OrdenId { get; set; }
        
    }
}