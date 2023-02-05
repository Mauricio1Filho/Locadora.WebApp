using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;

namespace Locadora.WebApp.Domain.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }
        public FilmeModel BuscarFilme(long idFilme)
        {
            return  _filmeRepository.BuscarFilme(idFilme);
        }
    }
}
