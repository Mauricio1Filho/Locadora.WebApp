using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Repositories;

namespace Locadora.WebApp.Domain.Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;

        public LocacaoService(ILocacaoRepository locacaoRepository)
        {
            _locacaoRepository = locacaoRepository;
        }

        public async Task<bool> CriarLocacaoFilmeAsync(long idCliente)
        {
            return await _locacaoRepository.CriarLocacaoFilmeAsync(idCliente);
        }
    }
}
