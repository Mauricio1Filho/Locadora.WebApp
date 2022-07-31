using System.Collections.Generic;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Domain.Interfaces
{
    public interface IFilmeService
    {
        FilmeModel BuscarFilme(long idFilme);
    }
}
