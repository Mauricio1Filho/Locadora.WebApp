using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class ReservaRepository : BaseRepositorio , IReservaRepository
    {
        private readonly MainContext _mainContext;

        public ReservaRepository(MainContext mainContext) : base(mainContext)
        {
            _mainContext = mainContext;
        }

        public async Task<bool> RemoverReservaAsync(long idReserva)
        {
            await _mainContext.Reservas.Remove(idReserva);
            
            return true;
        }

        public async Task<bool> ReservarFilmeAsync(long idFilme, long idUsuario)
        {
            return await _reservaRepository.ReservarFilmeAsync(idFilme, idUsuario);
        }
    }
}
