using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Infrastructure.Contexts;

namespace Vannon.Teste.WebApp.Infrastructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MainContext _mainContext;

        public LoginRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public async Task<UsuarioModel> LogarAsync(string usuario, string senha)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
            {
                 return await _mainContext.Usuarios.FirstOrDefaultAsync(o => o.Login.Equals(usuario) && o.Senha.Equals(senha));
            }
            return default;
        }
    }
}
