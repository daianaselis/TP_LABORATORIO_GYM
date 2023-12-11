using Microsoft.EntityFrameworkCore;
using Modelo.Clases;

namespace Datos
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Cliente>()
                .HasMany(e => e.Cuotas)
                .WithOne(e => e.Cliente)
                .OnDelete(DeleteBehavior.ClientCascade);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }
    }
}
