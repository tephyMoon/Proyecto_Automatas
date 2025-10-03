using Microsoft.EntityFrameworkCore;
using ProyectoLenguajes.Api.Models; // <-- Ahora esta línea funcionará correctamente

namespace ProyectoLenguajes.Api.Data // <-- Añadimos un namespace aquí también por consistencia
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Rol>().ToTable("Roles");
        }
    }
}