using System.Threading.Tasks;

namespace Vannon.Teste.WebApp.Domain.Interfaces
{
    public interface ILocacaoService
    {
        Task<bool> CriarReservaFilmeAsync(long clienteId, long filmeId);
    }
}
