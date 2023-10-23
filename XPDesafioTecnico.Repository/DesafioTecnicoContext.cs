using Microsoft.EntityFrameworkCore;
using XPDesafioTecnico.Models.Models;

namespace XPDesafioTecnico.Repository
{
    public class DesafioTecnicoContext : DbContext
    {
        public DesafioTecnicoContext(DbContextOptions<DesafioTecnicoContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.EnderecoPrincipal)
                .WithOne(e => e.Cliente)
                .HasForeignKey<Endereco>(e => e.ClienteID);
        }
    }
}
