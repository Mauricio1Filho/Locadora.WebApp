using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface IFilmeRepository
    {
        FilmeModel BuscarFilme(long idFilme);
    }
}
