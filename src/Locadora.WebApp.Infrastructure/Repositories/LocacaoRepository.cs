using System.Linq;
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

        public bool CriarLocacaoFilme(string cpf, int idFilme)
        {
            var dataset = _mainContext.Clientes
                .Where(x => x.Cpf == cpf )
                .Select(x => new ClienteModel { IdCliente = x.IdCliente });
            //_mainContext.Locacoes.Add();
            LocacaoFilmes locacaoFilmes = new LocacaoFilmes();
            {
                locacaoFilmes.FilmeId = idFilme;
            }
            _mainContext.LocacaoFilmes.Add(locacaoFilmes);
            //_mainContext.Locacoes.Add();
            _mainContext.SaveChanges();
            return true;
        }
    }
}


