using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
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
