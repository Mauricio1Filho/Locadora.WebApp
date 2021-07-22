using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vannon.Teste.WebApp.Domain.Repositories
{
    public interface ILocacaoRepository
    {
        Task<bool> CriarReservaFilmeAsync(long clienteId, long filmeId);
    }
}
