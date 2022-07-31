using System.Threading.Tasks;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface ILocacaoService
    {
        bool CriarLocacaoFilme(int idCliente);
    }
}
