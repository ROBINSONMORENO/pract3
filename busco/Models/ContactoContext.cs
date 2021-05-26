using Microsoft.EntityFrameworkCore ;

namespace busco.Models
{
    public class ContactoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
      
        public ContactoContext(DbContextOptions dco) : base(dco) {
        }  
    }
}