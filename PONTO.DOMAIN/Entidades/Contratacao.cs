using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("Contratacao")]
    public class Contratacao
    {
        [Key]
        public int IdContratacao { get; set; }

        [Required, MaxLength(120)]
        public string? Nome {get; set;}

        [Required, MaxLength(20)]
        public string? CPF {get; set;}

        [Required, MaxLength(20)]
        public string? Rg {get; set;}

        [MaxLength(20)]
        public string? Contrato {get; set;}

        [MaxLength(20)]
        public string? Funcionario {get; set;}

        [MaxLength(10)]
        public string? ValorContratado {get; set;}

        [MaxLength(10)]
        public string? ValorParcela {get; set;}

        [MaxLength(10)]
        public string? QtdParcela {get; set;}

        public DateTime DataContratacao {get; set;}

        [MaxLength(50)]
        public string? OrgaoPagador {get; set;}

        [MaxLength(50)]
        public string? TipoContratacao {get; set;}

        [MaxLength(20)]
        public string? Matricula { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
