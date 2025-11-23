using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectabairro.Models
{
    public class SolicitacaoEdicao
    {
        [Key] 
        public int SolicitacaoId { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        // Os novos dados que ele quer aprovar
        [Display(Name = "Nova Rua")]
        public string NovaRua { get; set; }

        [Display(Name = "Novo Bairro")]
        public string NovoBairro { get; set; }

        [Display(Name = "Nova Cidade")]
        public string NovaCidade { get; set; }

        [Display(Name = "Novo Estado")]
        public string NovoEstado { get; set; }

        public DateTime DataSolicitacao { get; set; } = DateTime.Now;

        // Status para o Admin controlar: "Pendente", "Aprovado", "Reprovado"
        public string Status { get; set; } = "Pendente";
    }
}