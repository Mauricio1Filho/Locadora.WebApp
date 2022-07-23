using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface ILoginRepository
    {
        Task<UsuarioModel> LogarAsync(string usuario, string senha);
    }
}
