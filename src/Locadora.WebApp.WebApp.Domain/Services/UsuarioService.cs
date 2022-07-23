using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.Domain.Repositories;

namespace Locadora.WebApp.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<UsuarioModel> PesquisarUsuarioAsync(long id)
        {
            return await _usuarioRepository.PesquisarUsuarioAsync(id);
        }
    }
}
