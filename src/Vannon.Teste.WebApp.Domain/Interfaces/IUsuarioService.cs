using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioModel> PesquisarUsuarioAsync(long id);
    }
}
