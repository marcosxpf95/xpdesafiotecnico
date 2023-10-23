using System.ComponentModel.DataAnnotations;
using XPDesafioTecnico.DataAnnotations;

namespace XPDesafioTecnico.DTOs
{
    public class ClienteCreationDto
    {
        [Required]
        [MaxLength(100)]
        public string NomeCompleto { get; set; }

        [Required]
        [CustomPhone]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Rua { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(100)]
        public string Estado { get; set; }

        [Required]
        [MaxLength(10)]
        public string CEP { get; set; }
    }
}
