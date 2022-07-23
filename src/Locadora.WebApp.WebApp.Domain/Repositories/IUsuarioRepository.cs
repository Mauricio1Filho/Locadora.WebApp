using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<UsuarioModel> PesquisarUsuarioAsync(long id);
    }
}
