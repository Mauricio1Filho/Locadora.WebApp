using System.Threading.Tasks;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface IReservaRepository
    {
        Task<bool> ReservarFilmeAsync(long idFilme, long idLocacao);
        Task<bool> RemoverReservaAsync(long idFilme, long idLocacao);
    }
}
