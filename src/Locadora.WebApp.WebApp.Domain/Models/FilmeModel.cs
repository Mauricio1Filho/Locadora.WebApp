using System;
using System.Collections.Generic;

namespace Locadora.WebApp.Domain.Models
{
    public class FilmeModel
    {
        public long IdFilme { get; set; }
        public string Titulo { get; set; }
        public long IdGenero { get; set; }
        public virtual GeneroModel Genero  { get; set; }
        public virtual ICollection<ReservaModel> Reservas{ get; set; }
        public double Preco { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
