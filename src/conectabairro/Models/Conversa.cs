using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectabairro.Models
{
    [Table("Conversas")]
    public class Conversa
    {
        [Key]
        public int ConversaId { get; set; }

        public int PostId { get; set; }
        public int AutorPostId { get; set; }
        public int InteressadoUsuarioId { get; set; }

        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime UltimaAtualizacao { get; set; } = DateTime.Now;

        [ForeignKey("PostId")]
        public Posts Post { get; set; }

        [ForeignKey("AutorPostId")]
        public Usuario AutorPost { get; set; }

        [ForeignKey("InteressadoUsuarioId")]
        public Usuario Interessado { get; set; }

        public ICollection<Mensagem> Mensagens { get; set; }
    }

}
