using System.Threading.Tasks;
using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;

namespace Locadora.WebApp.Domain.Services
{
    public class LoginService : ILoginService
    {

        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<UsuarioModel> LogarAsync(string usuario, string senha)
        {
            return await _loginRepository.LogarAsync(usuario, senha);
        }
    }
}
