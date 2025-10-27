using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectabairro.Models
{
    [Table("Reacao")]
    public class Reacao
    {
        [Key]
        public int ReacaoId { get; set; }

        public int PostId { get; set; }
        public int AutorUsuarioId { get; set; }

        [Required]
        public TipoReacao TipoReacao { get; set; }

        [ForeignKey("PostId")]
        public Posts Post { get; set; }

        [ForeignKey("AutorUsuarioId")]
        public Usuario Autor { get; set; }
    }

    public enum TipoReacao
    {
        Like,

        Dislike
    }
}
