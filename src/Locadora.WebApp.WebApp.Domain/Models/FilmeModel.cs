using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.WebApp.Domain.Models
{
    public class FilmeModel
    {       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdFilme { get; set; }
        public int FilmeIdGenero { get; set; }
        public ICollection<LocacaoFilmes> LocacaoFilmes { get; set; }
        public GeneroModel Genero { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; }
    }
}
