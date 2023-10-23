using XPDesafioTecnico.Models.Models;
using XPDesafioTecnico.Repository.Interfaces;
using XPDesafioTecnico.Services.Interfaces;

namespace XPDesafioTecnico.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task CreateCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            await _clienteRepository.CreateCliente(cliente);
        }

        public async Task<IReadOnlyCollection<Cliente>> GetClientes() => await _clienteRepository.GetClientes();

        public async Task<IReadOnlyCollection<Cliente>> GetClientesDetalhado() => await _clienteRepository.GetClientesDetalhado();
    }
}
