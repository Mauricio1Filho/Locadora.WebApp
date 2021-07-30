using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vannon.Teste.WebApp.Domain.Interfaces
{
    public interface IReservaService
    {
        Task<bool> ReservarFilmeAsync(long idFilme, long idLocacao);
        Task<bool> RemoverReservaAsync(long idFilme, long idLocacao);
    }
}
