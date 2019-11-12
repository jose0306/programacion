using Microsoft.AspNetCore.Identity;

namespace example.Models
{
    public class Usuario:IdentityUser
    {
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
    }
}