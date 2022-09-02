using Farmacia.modelos;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.datos
{
    public class ApplicationDbContext : DbContext
    {
        /* Constructor de la aplicacion*/
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        /* Tablas y modelos*/
        public DbSet<productos> productos { get; set; }

    }
}
