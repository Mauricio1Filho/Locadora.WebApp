using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly MainContext _mainContext;

        public ReservaRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public async Task<bool> RemoverReservaAsync(long idFilme, long idLocacao)
        {
            var result = await _mainContext.Reservas.FindAsync(idFilme, idLocacao);
            _mainContext.Remove(result);
            return true;
        }

        public async Task<bool> ReservarFilmeAsync(long idFilme, long idLocacao)
        {
            await _mainContext.Reservas.AddAsync(new ReservaModel {IdFilme = idFilme , IdLocacao = idLocacao });
            _mainContext.SaveChanges();
            return true;
        }
    }
}
