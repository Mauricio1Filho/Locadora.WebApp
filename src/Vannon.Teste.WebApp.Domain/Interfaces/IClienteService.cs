using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Domain.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteModel> BuscarClientAsync(long idCliente);
        Task<bool> RemoverClientAsync(long idCliente);
        Task<bool> AtualizarClientAsync(ClienteModel clienteModel);
        Task<bool> CadastrarClientAsync(ClienteModel clienteModel);
    }
}
