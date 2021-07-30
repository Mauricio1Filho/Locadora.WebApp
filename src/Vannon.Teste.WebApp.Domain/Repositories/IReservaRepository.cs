using System.Threading.Tasks;

namespace Vannon.Teste.WebApp.Domain.Repositories
{
    public interface IReservaRepository
    {
        Task<bool> ReservarFilmeAsync(long idFilme, long idLocacao);
        Task<bool> RemoverReservaAsync(long idFilme, long idLocacao);
    }
}
