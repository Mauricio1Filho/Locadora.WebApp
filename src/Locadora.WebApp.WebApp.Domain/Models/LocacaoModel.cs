using System;
using System.Collections.Generic;

namespace Locadora.WebApp.Domain.Models
{
    public class LocacaoModel
    {
        public long IdLocacao { get; set; }
        public long IdCliente { get; set; }
        public virtual ClienteModel Cliente { get; set; }
        public virtual ICollection<ReservaModel> Reservas { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
