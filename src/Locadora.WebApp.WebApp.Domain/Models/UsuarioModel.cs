using System;
using System.ComponentModel.DataAnnotations;

namespace Locadora.WebApp.Domain.Models
{
    public class UsuarioModel
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
