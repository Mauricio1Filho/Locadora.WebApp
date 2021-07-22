using System;
using System.Collections.Generic;

namespace Vannon.Teste.WebApp.Domain.Models
{
    public class UsuarioModel
    {
        public long IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
