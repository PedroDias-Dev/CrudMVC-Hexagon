using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }

    }
}
