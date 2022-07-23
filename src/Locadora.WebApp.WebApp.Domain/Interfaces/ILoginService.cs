using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface ILoginService 
    {
        Task<UsuarioModel> LogarAsync(string usuario, string senha);
    }
}
