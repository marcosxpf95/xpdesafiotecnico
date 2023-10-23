using XPDesafioTecnico.Models.Models;

namespace XPDesafioTecnico.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task CreateCliente(Cliente cliente);
        Task<IReadOnlyCollection<Cliente>> GetClientes();
        Task<IReadOnlyCollection<Cliente>> GetClientesDetalhado();
    }
}
