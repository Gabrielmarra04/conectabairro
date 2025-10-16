using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using conectabairro.Services;

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

        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }

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


        public string? ResetToken { get; set; }
        public DateTime? ResetTokenExpiry { get; set; }

    }

    public enum TipoUsuario
    {
        Admin,
        Morador,
        Ong
    }

}
