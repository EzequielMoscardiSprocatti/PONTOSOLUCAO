using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("ResultadoBotSefaz")]
    public  class ResultadoBot
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string? CPF { get; set; }

        [MaxLength(20)]
        public string? NOME { get; set; }

        [MaxLength(20)]
        public string? ORGAO { get; set; }

        [MaxLength(20)]
        public string? TPVINCULO { get; set; }

        [MaxLength(20)]
        public string? MBCONSIFACULTA { get; set; }

        [MaxLength(20)]
        public string? MBCARTAOCREDITO { get; set; }

        [MaxLength(20)]
        public string? MBCARTAOBENEF { get; set; }

        [MaxLength(20)]
        public string? MDCONSIFACULTA { get; set; }

        [MaxLength(20)]
        public string? MDCARTAOCREDITO { get; set; }

        [MaxLength(20)]
        public string? MDCARTAOBENEF { get; set; }

        [MaxLength(20)]
        public string? NUM_MATRICULA { get; set; }

        [MaxLength(20)]
        public string? QTD_NUM_MAT { get; set; }

        [MaxLength(20)]
        public string? MARGEM_5 { get; set; }

        [MaxLength(20)]
        public string? RESULTADO { get; set; }

        [MaxLength(20)]
        public string? MENSAGEM_CONSIGNADO { get; set; }

        [MaxLength(20)]
        public string? MENSAGEM_CARTAO_CREDITO { get; set; }
        public DateTime DataConsulta { get; set; }
    }
}
