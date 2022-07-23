using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MainContext _mainContext;
       
        public UsuarioRepository(MainContext mainContext) 
        {
            _mainContext = mainContext;
        }

        public async Task<UsuarioModel> PesquisarUsuarioAsync(long id)
        {
            return await _mainContext.Usuarios.FirstOrDefaultAsync(o => o.IdUsuario == id);
        }
    }
}
