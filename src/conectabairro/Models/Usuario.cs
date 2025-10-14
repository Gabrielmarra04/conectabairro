using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace conectabairro.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar seu Nome!")]
        [MaxLength(50)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório informar um Email!")]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório informar uma Senha!")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; } = string.Empty;

        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Rua!")]
        public string Rua { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório informar o Bairro!")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório informar a Cidade!")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório informar o Estado!")]
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório informar o tipo de usuário!")]
        public TipoUsuario TipoUsuarios { get; set; }

        
        public string? Cnpj { get; set; }

 
        public string? RazaoSocial { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Garante que a validação só ocorra se o tipo for ONG
            if (this.TipoUsuarios == TipoUsuario.Admin)
            {
                yield return new ValidationResult(
                    "Não é permitido cadastrar um usuário Administrador através do formulário de registro.",
                    new[] { nameof(TipoUsuario) });
            }

            if (TipoUsuarios == TipoUsuario.Ong)
            {
                if (string.IsNullOrWhiteSpace(this.Cnpj))
                {
                    yield return new ValidationResult(
                        "Obrigatório informar o CNPJ para o tipo de usuário ONG.",
                        new[] { nameof(Cnpj) });
                }

                if (string.IsNullOrWhiteSpace(RazaoSocial))
                {
                    yield return new ValidationResult(
                        "Obrigatório informar a Razão Social para o tipo de usuário ONG.",
                        new[] { nameof(RazaoSocial) });
                }
            }
            yield break;
        }
    }

    public enum TipoUsuario
    {
        Admin,
        Morador,
        Ong
    }

}
