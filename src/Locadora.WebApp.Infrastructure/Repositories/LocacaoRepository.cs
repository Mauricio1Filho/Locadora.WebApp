using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;
using System.Linq;

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
                .Where(x => x.Cpf == cpf)
                .Select(x => new ClienteModel { IdCliente = x.IdCliente }).SingleOrDefault();

            var locacao = new LocacaoModel()
            {
                ClienteIdCliente = dataset.IdCliente
            };

            var locacaoFilme = new LocacaoFilmes()
            {
                FilmeId = idFilme,
                Locacao = locacao
            };
            _mainContext.Locacoes.Add(locacao);
            _mainContext.LocacaoFilmes.Add(locacaoFilme);
            _mainContext.SaveChanges();
            return true;
        }
    }
}


