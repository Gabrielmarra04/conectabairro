using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectabairro.Models
{
    public class EdicaoPost : Posts
    {
        [NotMapped]
        [Display(Name = "Imagem do Post")]
        public IFormFile? ImagemArquivoEdicao { get; set; }
    }
}
