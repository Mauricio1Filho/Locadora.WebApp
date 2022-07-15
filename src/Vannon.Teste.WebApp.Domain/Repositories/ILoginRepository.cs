using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Domain.Repositories
{
    public interface ILoginRepository
    {
        Task<UsuarioModel> LogarAsync(string usuario, string senha);
    }
}
