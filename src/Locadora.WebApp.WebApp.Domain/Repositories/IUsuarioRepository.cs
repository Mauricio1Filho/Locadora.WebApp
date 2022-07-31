using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        UsuarioModel PesquisarUsuario(long id);
    }
}
