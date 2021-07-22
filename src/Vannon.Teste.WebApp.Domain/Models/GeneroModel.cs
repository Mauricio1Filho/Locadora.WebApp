using System;
using System.Collections.Generic;

namespace Vannon.Teste.WebApp.Domain.Models
{
    public class GeneroModel
    {
        public long IdGenero { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<FilmeModel> Filmes { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
