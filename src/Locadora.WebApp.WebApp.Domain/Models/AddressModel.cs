using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.WebApp.Domain.Models
{
    public class AddressModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [ForeignKey("IdEndereco")]
        public int IdEndereco { get; set; }
        public ClienteModel Cliente { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string CEP { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
    }
}
