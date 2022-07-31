using System.Threading.Tasks;
using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;

namespace Locadora.WebApp.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool AtualizarClient(ClienteModel clienteModel)
        {
            return  _clienteRepository.AtualizarClient(clienteModel);
        }

        public ClienteModel BuscarClient(long idCliente)
        {
            return  _clienteRepository.BuscarClient(idCliente);
        }

        public ClienteModel BuscarClientCpf(string cpf)
        {
            return _clienteRepository.BuscarClientCpf(cpf);
        }

        public bool CadastrarClient(ClienteModel clienteModel)
        {
            return _clienteRepository.CadastrarClient(clienteModel);
        }

        public bool RemoverClient(long idCliente)
        {
            return _clienteRepository.RemoverClient(idCliente);
        }
    }
}
