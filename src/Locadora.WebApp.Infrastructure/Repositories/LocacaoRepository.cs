using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class LocacaoRepository : ILocacaoRepository
    {
        private readonly MainContext _mainContext;

        public LocacaoRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public bool CriarLocacaoFilme(int idCliente)
        {
            _mainContext.Clientes.Add(new ClienteModel { IdCliente = idCliente });
            _mainContext.SaveChanges();
            return true;
        }
    }
}
