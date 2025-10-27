using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [DisplayName("Tipo de Usuário")]
        [Required(ErrorMessage = "Obrigatório informar o tipo de usuário!")]
        public TipoUsuario TipoUsuarios { get; set; }

        public string? Cnpj { get; set; }

        [DisplayName("Razão Social")]
        public string? RazaoSocial { get; set; }


        public string? ResetToken { get; set; }
        public DateTime? ResetTokenExpiry { get; set; }

        public ICollection<Posts> PostsCriados { get; set; }

        public ICollection<Conversa> ConversasIniciadas { get; set; }

        public ICollection<Mensagem> MensagensEnviadas { get; set; }

        public ICollection<Comentario> ComentariosFeitos { get; set; }
    }

}
