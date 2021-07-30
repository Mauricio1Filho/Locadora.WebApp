using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
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
