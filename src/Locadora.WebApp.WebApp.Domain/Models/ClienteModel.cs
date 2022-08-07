using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.WebApp.Domain.Models
{
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdCliente { get; set; }
        public int ClienteIdContato { get; set; }
        public int ClienteIdEndereco { get; set; }        
        public ContactModel Contato { get; set; }
        public AddressModel Endereco { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Sexo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataNascimento { get; set; }        
    }    
}
