using System.Threading.Tasks;

namespace Vannon.Teste.WebApp.Domain.Interfaces
{
    public interface ILoginService 
    {
        Task<bool> LogarAsync(string usuario, string senha);
    }
}
