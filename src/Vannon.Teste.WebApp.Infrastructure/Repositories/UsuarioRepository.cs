using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepositorio, IUsuarioRepository
    {
        private readonly MainContext _mainContext;
       
        public UsuarioRepository(MainContext mainContext) : base(mainContext)
        {
            _mainContext = mainContext;
        }

        public async Task<UsuarioModel> PesquisarUsuarioAsync(long id)
        {
            return await _mainContext.Usuarios.Where(o => o.IdUsuario == id).FirstOrDefaultAsync();
        }
    }
}
