using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;

namespace Vannon.Teste.WebApp.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> AtualizarClientAsync(ClienteModel clienteModel)
        {
            return await _clienteRepository.AtualizarClientAsync(clienteModel);
        }

        public async Task<ClienteModel> BuscarClientAsync(long idCliente)
        {
            return await _clienteRepository.BuscarClientAsync(idCliente);
        }

        public async Task<ClienteModel> BuscarClientCpfAsync(string cpf)
        {
            return await _clienteRepository.BuscarClientCpfAsync(cpf);
        }

        public async Task<bool> CadastrarClientAsync(ClienteModel clienteModel)
        {
            return await _clienteRepository.CadastrarClientAsync(clienteModel);
        }

        public async Task<bool> RemoverClientAsync(long idCliente)
        {
            return await _clienteRepository.RemoverClientAsync(idCliente);
        }
    }
}
