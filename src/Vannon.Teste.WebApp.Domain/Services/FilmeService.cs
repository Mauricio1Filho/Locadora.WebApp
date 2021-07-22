using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;

namespace Vannon.Teste.WebApp.Domain.Services
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
