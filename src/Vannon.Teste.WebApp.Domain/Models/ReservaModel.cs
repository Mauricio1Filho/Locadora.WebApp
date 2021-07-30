using System.Collections.Generic;

namespace Vannon.Teste.WebApp.Domain.Models
{
    public class ReservaModel
    {
        public long IdFilme { get; set; }
        public long IdLocacao { get; set; }
        public virtual FilmeModel Filme { get; set; }
        public virtual LocacaoModel Locacao { get; set; }
    }
}
