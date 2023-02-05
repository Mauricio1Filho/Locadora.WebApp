using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface ILoginRepository
    {
        UsuarioModel Logar(string usuario, string senha);
    }
}
