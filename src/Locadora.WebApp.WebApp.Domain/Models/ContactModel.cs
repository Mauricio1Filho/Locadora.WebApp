using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.WebApp.Domain.Models
{
    public class ContactModel 
    {        
        [Key]
        [ForeignKey("IdContato")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContato { get; set; }       
        [Required]
        public string Email { get; set; }
        public string Celular { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}
