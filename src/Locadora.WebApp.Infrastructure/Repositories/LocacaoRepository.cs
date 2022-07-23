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

        public async Task<bool> CriarLocacaoFilmeAsync(long idCliente)
        {
            await  _mainContext.Locacoes.AddAsync (new LocacaoModel {IdCliente = idCliente });
            await _mainContext.SaveChangesAsync();
            return true; 
        }
    }
}
