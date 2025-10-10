using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectabairro.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [ForeignKey("Usuario")]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar um Título!")]
        [MaxLength(150)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar uma Descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar uma Categoria!")]
        public Categoria Categoria { get; set; }

        public StatusPost Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Obrigatório adicionar ao menos 1 anexo!")]
        [NotMapped] // não mapeia no banco
        [Display(Name = "Imagem do Post")]
        public IFormFile? ImagemArquivo { get; set; } // Upload no formulário
        public string? CaminhoImagem { get; set; }
       
        public int LikesCount { get; set; }

        public virtual Usuario Usuario { get; set; } = null!;
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
