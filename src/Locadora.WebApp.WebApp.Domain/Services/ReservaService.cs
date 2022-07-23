using System.Threading.Tasks;
using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Repositories;

namespace Locadora.WebApp.Domain.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public async Task<bool> RemoverReservaAsync(long idFilme, long idLocacao)
        {
            return await _reservaRepository.RemoverReservaAsync(idFilme, idLocacao);
        }

        public async Task<bool> ReservarFilmeAsync(long idFilme, long idLocacao)
        {
            return await _reservaRepository.ReservarFilmeAsync(idFilme, idLocacao);
        }

    }
}
