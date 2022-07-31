using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.WebApp.Domain.Models
{
    public class LocacaoFilmes
    {
        public int FilmeId { get; set; }
        public int LocacaoId { get; set; }
        public LocacaoModel Locacao{ get; set; }
        public FilmeModel Filme{ get; set; }
    }
}
