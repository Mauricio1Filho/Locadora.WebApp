using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Domain.Repositories
{
    public interface IFilmeRepository
    {
        Task<FilmeModel> BuscarFilmeAsync(long idFilme);
    }
}
