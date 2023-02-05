using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioModel PesquisarUsuario(long id);
    }
}
