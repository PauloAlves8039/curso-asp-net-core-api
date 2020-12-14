using System.ComponentModel.DataAnnotations;

namespace src.Api.Domain.Dtos
{
    /// <summary>
    /// Classe responsável por atribuir propriedade do login.
    /// </summary>
    public class LoginDto
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para Login!")]
        [EmailAddress(ErrorMessage = "Email em formato inválido!")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres!")]
        public string Email { get; set; }
    }
}
