using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace progra.Models
{
    public class TiendaContext : IdentityDbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public TiendaContext(DbContextOptions<TiendaContext> o) : base(o){
            
        }
    
    }
}