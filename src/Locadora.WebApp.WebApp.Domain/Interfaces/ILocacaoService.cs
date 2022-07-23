using System.Threading.Tasks;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface ILocacaoService
    {
        Task<bool> CriarLocacaoFilmeAsync(long idCliente);
    }
}
