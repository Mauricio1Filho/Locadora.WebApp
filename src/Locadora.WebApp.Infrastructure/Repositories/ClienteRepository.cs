using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MainContext _mainContext;

        public ClienteRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public bool AtualizarClient(ClienteModel clienteModel)
        {
            Task.FromResult(_mainContext.Clientes.Update(clienteModel));
            return true;
        }

        public ClienteModel BuscarClient(long idCliente)
        {
            return _mainContext.Clientes.FirstOrDefault(o => o.IdCliente == idCliente);
        }

        public ClienteModel BuscarClientCpf(string cpf)
        {
            return _mainContext.Clientes.FirstOrDefault(o => o.Cpf == cpf);
        }

        public bool CadastrarClient(ClienteModel clienteModel)
        {
            _mainContext.Clientes.Add(clienteModel);
            _mainContext.SaveChanges();
            return true;
        }

        public bool RemoverClient(long idCliente)
        {
            var result = _mainContext.Clientes.Find(idCliente);
            _mainContext.Remove(result);
            return true;
        }
    }
}
