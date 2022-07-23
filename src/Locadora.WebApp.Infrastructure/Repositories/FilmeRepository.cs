using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly MainContext _mainContext;
        public FilmeRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }
        public async Task<FilmeModel> BuscarFilmeAsync(long idFilme)
        {
            return await _mainContext.Filmes.FirstOrDefaultAsync(o => o.IdFilme == idFilme);
        }
    }
}
