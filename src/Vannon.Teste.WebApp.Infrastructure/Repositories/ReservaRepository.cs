using System.Threading.Tasks;
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

        public async Task<bool> RemoverReservaAsync(long IdCliente)
        {
            var result = await _mainContext.Reservas.FindAsync(IdCliente);
            _mainContext.Remove(result);
            return true;
        }

        public async Task<bool> ReservarFilmeAsync(long idFilme, long idUsuario)
        {
            await _mainContext.Reservas.AddRangeAsync();
            _mainContext.SaveChanges();
            return true;
        }
    }
}
