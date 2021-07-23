using System.Threading.Tasks;

namespace Vannon.Teste.WebApp.Domain.Repositories
{
    public interface ILoginRepository
    {
        Task<bool> LogarAsync(string usuario, string senha);
    }
}
