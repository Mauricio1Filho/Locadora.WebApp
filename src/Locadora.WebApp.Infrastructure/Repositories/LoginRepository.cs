using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Infrastructure.Contexts;
using System.Linq;

namespace Locadora.WebApp.Infrastructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MainContext _mainContext;

        public LoginRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public UsuarioModel Logar(string usuario, string senha)
        {

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
            {
                return  _mainContext.Usuarios.FirstOrDefault(o => o.Login.Equals(usuario) && o.Senha.Equals(senha));                
            }
            return default;
        }
    }
}
