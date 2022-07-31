using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.WebApp.Domain.Models
{
    public class GeneroModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdGenero { get; set; }
        public virtual ICollection<FilmeModel> Filmes { get; set; }
        [Required]
        public string Descricao { get; set; }        
        public DateTime DataCriacao { get; set; }
    }
}
