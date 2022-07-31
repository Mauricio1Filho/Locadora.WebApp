using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface ILoginService 
    {
        UsuarioModel Logar(string usuario, string senha);
    }
}
