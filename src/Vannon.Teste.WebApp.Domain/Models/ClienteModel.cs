using System;
using System.Collections.Generic;

namespace Vannon.Teste.WebApp.Domain.Models
{
    public class ClienteModel
    {
        public long IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public virtual ICollection<LocacaoModel> Locacoes { get; set; }
        public virtual ICollection<ReservaModel> Reservas { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
