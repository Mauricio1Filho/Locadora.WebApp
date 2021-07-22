using System.Collections.Generic;

namespace Vannon.Teste.WebApp.Domain.Models
{
    public class ReservaModel
    {
        public long IdFilme { get; set; }
        public long IdCliente { get; set; }
        public virtual FilmeModel Filme { get; set; }
        public virtual ClienteModel Cliente { get; set; }
    }
}
