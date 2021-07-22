using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly IFilmeService _filmeService;

        public FilmeRepository(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }
        public async Task<FilmeModel> BuscarFilmeAsync(long idFilme)
        {
            return await _filmeService.BuscarFilmeAsync(idFilme);
        }
    }
}
