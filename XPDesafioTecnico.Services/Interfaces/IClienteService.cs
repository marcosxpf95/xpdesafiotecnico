using XPDesafioTecnico.Models.Models;

namespace XPDesafioTecnico.Services.Interfaces
{
    public interface IClienteService
    {
        Task CreateCliente(Cliente cliente);
        Task<IReadOnlyCollection<Cliente>> GetClientes();
        Task<IReadOnlyCollection<Cliente>> GetClientesDetalhado();
    }
}
