using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace example.Models
{
    public class TiendaContext: IdentityDbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public TiendaContext(DbContextOptions<TiendaContext> o) : base(o){
            
        }
    }
}