using System.Collections.Generic;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Domain.Interfaces
{
    public interface IFilmeService
    {
        Task<FilmeModel> BuscarFilmeAsync(long idFilme);
    }
}
