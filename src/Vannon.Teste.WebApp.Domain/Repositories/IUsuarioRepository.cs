using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<UsuarioModel> PesquisarUsuarioAsync(long id);
    }
}
