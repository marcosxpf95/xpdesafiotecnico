using Microsoft.EntityFrameworkCore;
using XPDesafioTecnico.Models.Models;
using XPDesafioTecnico.Repository.Interfaces;

namespace XPDesafioTecnico.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DesafioTecnicoContext _context;

        public ClienteRepository(DesafioTecnicoContext context)
        {
            _context = context;
        }

        public async Task CreateCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Cliente>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<IReadOnlyCollection<Cliente>> GetClientesDetalhado()
        {
            return await _context.Clientes
                .Include(c => c.EnderecoPrincipal)
                .ToListAsync();
        }
    }
}
