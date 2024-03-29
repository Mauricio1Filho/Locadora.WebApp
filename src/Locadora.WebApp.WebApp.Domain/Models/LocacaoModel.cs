﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.WebApp.Domain.Models
{
    public class LocacaoModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int IdLocacao { get; set; }
        public int ClienteIdCliente { get; set; }
        public ClienteModel Cliente { get; set; }
        public ICollection<LocacaoFilmes> LocacaoFilmes { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; }
    }
}
