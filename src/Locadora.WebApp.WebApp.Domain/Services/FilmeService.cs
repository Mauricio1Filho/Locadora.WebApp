using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<FilmeModel> BuscarFilmeAsync(long idFilme)
        {
            return await _filmeRepository.BuscarFilmeAsync(idFilme);
        }
    }
}
