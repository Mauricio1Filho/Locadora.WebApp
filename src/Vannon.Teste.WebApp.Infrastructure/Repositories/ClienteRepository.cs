using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MainContext _mainContext;

        public ClienteRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public async Task<bool> AtualizarClientAsync(ClienteModel clienteModel)
        {
            await Task.FromResult(_mainContext.Clientes.Update(clienteModel));
            return true;
        }

        public async Task<ClienteModel> BuscarClientAsync(long idCliente)
        {
            return await _mainContext.Clientes.FirstOrDefaultAsync(o => o.IdCliente == idCliente);
        }

        public async Task<bool> CadastrarClientAsync(ClienteModel clienteModel)
        {
            await _mainContext.Clientes.AddAsync(clienteModel);
            _mainContext.SaveChanges();
            return true;
        }

        public async Task<bool> RemoverClientAsync(long idCliente)
        {
            var result = await _mainContext.Clientes.FindAsync(idCliente);
            _mainContext.Remove(result);
            return true;
        }
    }
}
