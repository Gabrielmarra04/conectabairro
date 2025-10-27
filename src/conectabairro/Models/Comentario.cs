using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectabairro.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }

        public int PostId { get; set; }
        public int AutorUsuarioId { get; set; }

        [Required]
        public string Conteudo { get; set; }

        public DateTime DataEnvio { get; set; } = DateTime.Now;

        [ForeignKey("PostId")]
        public Posts Post { get; set; }

        [ForeignKey("AutorUsuarioId")]
        public Usuario Autor { get; set; }
    }

}
