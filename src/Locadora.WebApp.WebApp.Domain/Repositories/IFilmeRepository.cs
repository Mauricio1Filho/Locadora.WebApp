using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface IFilmeRepository
    {
        Task<FilmeModel> BuscarFilmeAsync(long idFilme);
    }
}
