using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;
using System.Linq;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly MainContext _mainContext;
        public FilmeRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }
        public FilmeModel BuscarFilme(long idFilme)
        {
            return _mainContext.Filmes.FirstOrDefault(o => o.IdFilme == idFilme);
        }
    }
}
