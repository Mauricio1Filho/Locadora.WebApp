using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface IClienteRepository
    {
        ClienteModel BuscarClient(long idCliente);
        ClienteModel BuscarClientCpf(string cpf);
        bool RemoverClient(long idCliente);
        bool AtualizarClient(ClienteModel clienteModel);
        bool CadastrarClient(ClienteModel clienteModel);
    }
}
