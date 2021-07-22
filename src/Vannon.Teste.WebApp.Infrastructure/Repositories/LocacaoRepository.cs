using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Repositories;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class LocacaoRepository : ILocacaoRepository
    {
        private readonly ILocacaoService _locacaoService;

        public LocacaoRepository(ILocacaoService locacaoService)
        {
            _locacaoService = locacaoService;
        }
        public async Task<bool> CriarReservaFilmeAsync(long clienteId, long filmeId)
        {
            return await _locacaoService.CriarReservaFilmeAsync(clienteId, filmeId);
        }
    }
}
