using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Repositories;

namespace Vannon.Teste.WebApp.Domain.Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;

        public LocacaoService(ILocacaoRepository locacaoRepository)
        {
            _locacaoRepository = locacaoRepository;
        }

        public async Task<bool> CriarReservaFilmeAsync(long clienteId, long filmeId)
        {
            return await _locacaoRepository.CriarReservaFilmeAsync(clienteId, filmeId);
        }
    }
}
