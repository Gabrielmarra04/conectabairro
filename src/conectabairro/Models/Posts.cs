using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace conectabairro.Models
{
    [Table("Posts")]
    public class Posts
    {
        [Key]
        public int PostId { get; set; }

        [ForeignKey("Usuario")]
        public int AutorId { get; set; }

        [Display(Name = "Título")]  
        [Required(ErrorMessage = "Obrigatório informar um Título!")]
        [MaxLength(150)]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório informar uma Descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar uma Categoria!")]
        public Categoria Categoria { get; set; }

        public StatusPost Status { get; set; } = StatusPost.Pendente;

        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Obrigatório adicionar ao menos 1 anexo!")]
        [NotMapped]
        [Display(Name = "Imagem do Post")]
        public IFormFile? ImagemArquivo { get; set; }
        public string? CaminhoImagem { get; set; }

        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }

        public virtual Usuario Usuario { get; set; } = null!;

        public ICollection<Comentario> Comentarios { get; set; }

        public ICollection<Reacao> Reacoes { get; set; }
        
        [NotMapped]
        public ICollection<Conversa> Conversas { get; set; }

        [NotMapped]
        public Comentario Comentario { get; set; }
        [NotMapped]
        public Usuario UsuarioLogado { get; set; }
    }

    public enum Categoria
    {
        [Display(Name = "Esporte e Lazer")]
        EsporteELazer,

        [Display(Name = "Saúde")]
        Saude,

        [Display(Name = "Zeladoria")]
        Zeladoria,

        [Display(Name = "Comércio e Serviços")]
        ComercioEServicos,

        [Display(Name = "Alertas")]
        Alertas
    }

    public enum StatusPost
    {
        [Display(Name = "Pendente")]
        Pendente,

        [Display(Name = "Em andamento")]
        EmAandamento,

        [Display(Name = "Resolvido")]
        Resolvido
    }
}
