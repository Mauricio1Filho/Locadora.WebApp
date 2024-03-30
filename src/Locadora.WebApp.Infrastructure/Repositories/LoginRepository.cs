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

        public UsuarioModel Logar(string usuario, string senha) =>
            _mainContext.Usuarios.FirstOrDefault(o => o.Login.Equals(usuario) && o.Senha.Equals(senha));

    }
}
