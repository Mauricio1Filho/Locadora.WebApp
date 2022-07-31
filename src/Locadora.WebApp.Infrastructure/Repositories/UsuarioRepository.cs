using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;
using System.Linq;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MainContext _mainContext;
       
        public UsuarioRepository(MainContext mainContext) 
        {
            _mainContext = mainContext;
        }

        public UsuarioModel PesquisarUsuario(long id)
        {
            return _mainContext.Usuarios.FirstOrDefault(o => o.IdUsuario == id);
        }
    }
}
