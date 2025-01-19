using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Dtos.Auth;

public class CreateUserDto : BaseUserDto
{
    [Required]
    [MaxLength(20, ErrorMessage = "Nome só pode ter 20 caracteres!")]
    public required string Nome { get; set; }
}
