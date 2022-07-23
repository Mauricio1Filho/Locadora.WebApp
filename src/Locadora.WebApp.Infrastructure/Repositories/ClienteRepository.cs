using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;

namespace Locadora.WebApp.Infrastructure.Repositories
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

        public async Task<ClienteModel> BuscarClientCpfAsync(string cpf)
        {
            return await _mainContext.Clientes.FirstOrDefaultAsync(o => o.Cpf == cpf);
        }

        public async Task<bool> CadastrarClientAsync(ClienteModel clienteModel)
        {
            if (clienteModel != null && clienteModel.Nome == string.Empty && clienteModel.Cpf == string.Empty)
            {
                return false;
            }
            else
            {
                await _mainContext.Clientes.AddAsync(clienteModel);
                _mainContext.SaveChanges();
                return true;
            }
        }

        public async Task<bool> RemoverClientAsync(long idCliente)
        {
            var result = await _mainContext.Clientes.FindAsync(idCliente);
            _mainContext.Remove(result);
            return true;
        }
    }
}
