using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectabairro.Models
{
    [Table("Mensagens")]
    public class Mensagem
    {
        [Key]
        public int MensagemId { get; set; }

        public int ConversaId { get; set; }
        public int RemetenteUsuarioId { get; set; }

        [Required]
        public string Conteudo { get; set; }

        public DateTime DataEnvio { get; set; } = DateTime.Now;

        public bool Lida { get; set; } = false;

        [ForeignKey("ConversaId")]
        public Conversa Conversa { get; set; }

        [ForeignKey("RemetenteUsuarioId")]
        public Usuario Remetente { get; set; }
    }

}
