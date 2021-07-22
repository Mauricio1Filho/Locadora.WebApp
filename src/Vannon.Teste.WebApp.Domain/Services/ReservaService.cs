using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Repositories;

namespace Vannon.Teste.WebApp.Domain.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public async Task<bool> RemoverReservaAsync(long idReserva)
        {
            return await _reservaRepository.RemoverReservaAsync(idReserva);
        }

        public async Task<bool> ReservarFilmeAsync(long idFilme, long idUsuario)
        {
            return await _reservaRepository.ReservarFilmeAsync(idFilme, idUsuario);
        }

    }
}
