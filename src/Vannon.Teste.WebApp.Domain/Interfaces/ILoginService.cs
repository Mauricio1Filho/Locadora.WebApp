using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Domain.Interfaces
{
    public interface ILoginService 
    {
        Task<UsuarioModel> LogarAsync(string usuario, string senha);
    }
}
