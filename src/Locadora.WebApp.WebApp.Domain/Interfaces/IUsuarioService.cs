using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioModel> PesquisarUsuarioAsync(long id);
    }
}
