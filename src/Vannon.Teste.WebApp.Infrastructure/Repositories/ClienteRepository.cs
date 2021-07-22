using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class ClienteRepository :  BaseRepositorio, IClienteRepository 
    {
        private readonly IClienteService _clienteService;

        public ClienteRepository(MainContext mainContext) : base(mainContext)
        {

        }
        
        public async Task <bool> AtualizarClientAsync(ClienteModel clienteModel)
        {
            return await _clienteService.AtualizarClientAsync(clienteModel);
        }

        public async Task<ClienteModel> BuscarClientAsync(long idCliente)
        {
            return await _clienteService.BuscarClientAsync(idCliente);
        }

        public async Task<bool> CadastrarClientAsync(ClienteModel clienteModel)
        {
            return await _clienteService.CadastrarClientAsync(clienteModel);
        }

        public async Task<bool> RemoverClientAsync(long idCliente)
        {
            return await _clienteService.RemoverClientAsync(idCliente);
        }
    }
}
