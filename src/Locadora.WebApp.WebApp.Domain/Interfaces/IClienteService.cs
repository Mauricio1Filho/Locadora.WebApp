using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteModel> BuscarClientAsync(long idCliente);
        Task<ClienteModel> BuscarClientCpfAsync(string cpf);
        Task<bool> RemoverClientAsync(long idCliente);
        Task<bool> AtualizarClientAsync(ClienteModel clienteModel);
        Task<bool> CadastrarClientAsync(ClienteModel clienteModel);
    }
}
