using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.WebApp.Domain.Repositories
{
    public interface ILocacaoRepository
    {
        bool CriarLocacaoFilme(int idCliente);
    }
}
