using AutoMapper;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Services;
using Locadora.WebApp.ViewModel;

namespace Locadora.WebApp.Application.Services
{
    public class UsuarioServiceApp
    {
        private readonly IMapper _mapper;

        private readonly UsuarioService _usuarioService;

        public UsuarioServiceApp(UsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        public LoginViewModel PesquisarUsuario(long id)
        {
            return _mapper.Map<LoginViewModel>(_usuarioService.PesquisarUsuario(id));
        }
    }
}
