using Microsoft.EntityFrameworkCore;

namespace Catalogo.Modelos
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Bicicleta> Bicicletas { get; set; }
        public DbSet<Alquiler> Alquileres { get; set;}

    }
}
